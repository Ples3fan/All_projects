<?php
require_once 'vendor\autoload.php';
require_once 'config.php';
class YouTubeVideo
{

    public $id; //id видео

    public $apiKey = 'AIzaSyCGrmZHludJVT9ycf05TRWDv7I1ivC8DtA';

    public $youtube;


    public function __construct()
    {
        $client = new Google_Client();
        $client->setDeveloperKey($this->apiKey);

        $this->youtube = new Google_Service_YouTube($client);

    }


    /*
    * Получение данных видео по их id
    */
    public function videosByIds( string $ids)
    {
        return $this->youtube->videos->listVideos('snippet, statistics, contentDetails', [
            'id' => $ids,
        ]);
    }

    /**
     * Получение списка популярных видео (данные - snippet и statistics)
     */
    public function videos(int $maxResults=10, string $region='UA')
    {
        return $this->youtube->videos->listVideos('snippet, statistics, contentDetails', [
            'chart' => 'mostPopular',
            'maxResults' => $maxResults,
            'regionCode' => $region,
        ]);
    }


    /**
     * Поиск видео по фразе
     */
    public function search(string $q, int $maxResults=50, string $lang='ru' ){

        $response = $this->youtube->search->listSearch('snippet',
            array(
                'q' => $q,
                'maxResults' => $maxResults,
                'relevanceLanguage' => $lang,
                'type' => 'video'
            ));

        return $response;

    }


    /** Получить список категорий видео с YouTube
     * https://developers.google.com/youtube/v3/docs/videoCategories
     * Возвращает массив с id категорий
     */
    public function getCategory($regionCode = 'UA'){
        $result = $this->youtube->videoCategories->listVideoCategories('snippet',
            array('hl' => 'ru', 'regionCode' => $regionCode));

        $category = [];
        $array = $result->getItems(); //масиив объектов Google_Service_YouTube_VideoCategory

        array_walk($array, function ($value) use (&$category){
            $category[$value['id']] =  $value['snippet']['title'];
        });

        return $category;
    }


    /**
     * Поиск самых популярных видео по указанной категории
     */
    public function getPopularVideosByCategory( string $videoCategoryId, int $maxResults=10, string $region='UA', $pageToken=null){

        try {
            $response = $this->youtube->videos->listVideos('snippet, statistics, contentDetails',
                array('videoCategoryId' => $videoCategoryId,
                    'maxResults' => $maxResults,
                    'regionCode' => $region,
                    'chart' => 'mostPopular',
                    'pageToken' => $pageToken,
                ));

        } catch (\Google_Service_Exception $e){
            return false;
        }

        return $response; //массив объектов Google_Service_YouTube_Video

    }

    public function getDataVideo(array $videos){
        //global $db;
        $dataset = [];
        array_walk($videos, function ($value) use (&$dataset){
    
            $dataset[] = [
                'id' => $value->toSimpleObject()->id,
                'title' => $value->toSimpleObject()->snippet['title'],
                'thumbnails' => [
                    'default' =>  $value->toSimpleObject()->snippet['thumbnails']['default']['url']
                ],
                'viewCount' => $value->toSimpleObject()->statistics['viewCount'],
                'publishedAt'=> $value->toSimpleObject()->snippet['publishedAt'],
                'channelId' => $value->toSimpleObject()->snippet['channelId']
                
    
            ];
            /* foreach($dataset as $item){
                $title=$item->title;
                $
            } */
        });
    
        return $dataset;
    }

    public function timeFormatting($duration){

        $interval = new \DateInterval($duration);
        $seconds = $interval->days * 86400 + $interval->h * 3600 + $interval->i * 60 + $interval->s;
    
        $time = gmdate("H:i:s", $seconds);
        return $time;
    
    }

    public function getThis($dataById){
        $videos_date = $this->getDataVideo($dataById->getItems());
        return $videos_date;
    }

    public function razborVideo(array $videos){
        $title='';
        $view='';
        $date='';
        $author='';
        $img='';
        $apikey = 'AIzaSyCGrmZHludJVT9ycf05TRWDv7I1ivC8DtA';
        foreach($videos as $item){
            $id=$item->videoId;
            $json_result = file_get_contents("https://www.googleapis.com/youtube/v3/videos?part=statistics&id=$id&key=$apikey");
            $obj = json_decode($json_result);
            foreach($obj->items as $item) {
                 echo $item->id->videoId."<br>";
            }

        }
        /* $dataset = [];
        array_walk($videos, function ($value) use (&$dataset){
    
            $dataset[] = [
                'id' => $value->toSimpleObject()->id,
                'title' => $value->toSimpleObject()->snippet['title'],
                'thumbnails' => [
                    'default' =>  $value->toSimpleObject()->snippet['thumbnails']['default']['url']
                ],
                'viewCount' => $value->toSimpleObject()->statistics['viewCount'],
                'publishedAt'=> $value->toSimpleObject()->snippet['publishedAt'],
                'channelId' => $value->toSimpleObject()->snippet['channelId']
                
    
            ]; */
            /* foreach($dataset as $item){
                $title=$item->title;
                $
            } */
       // });
    }
}