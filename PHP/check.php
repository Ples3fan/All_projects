<?php
if($_SERVER['REQUEST_METHOD'] == 'GET') {
    $search = $_GET['sear']; 
}
require_once 'YouTubeVideo.php';
    
    $video = new YouTubeVideo();
    $video2 = new YouTubeVideo();
    $video3 = new YouTubeVideo();
    $dataBySearch = $video->search($search);
    $videos_date = $video2->getThis($dataBySearch);
    $apikey = "AIzaSyCGrmZHludJVT9ycf05TRWDv7I1ivC8DtA";
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <title>Document</title>
</head>
<body>
    <div>
        <form action="check.php" method="GET" >
            <div class="container">
            <div class="form-group">
            <label for="formGroupExampleInput">Введите тему для парсинга</label>
            <input name="sear" type="text" class="form-control" id="formGroupExampleInput" placeholder="Тема парсинга">
            </div>
            <input class="btn btn-primary" type="submit" value="Submit">
        </form>
        
    </div>
    <div>
        <?php
        //print_r($videos_date);
        /* foreach($videos_date as $item){
            "<p>".$item->videoId."</p>";
        } */

       //print_r($razbor);
       /* $cart = array();
       foreach($obj->items as $item) {
        array_push($cart, $item->id->videoId);
        }
        print_r($ids); */
        //$item->id->videoId;
        /* foreach($item->id as $ident){
            $temp=$ident->videoId;
             $json_result = file_get_contents("https://www.googleapis.com/youtube/v3/videos?part=statistics&id=$temp&key=$apikey");
             $object = json_decode($json_result);
             foreach($object->items as $vvi){
                 echo $vvi->statistics->viewCount;
             }
            } */
        ?>
        <hr>
         <? foreach ($videos_date as $item) :?>
        <p><img align="left" src="<?=$item['thumbnails']['default'];?>"></p>
            <?php $temp=$item['id']['videoId'];
            $dataById = $video->videosByIds($temp);
            $videos_view = $video3->getThis($dataById);
            $check=$videos_view[0]['viewCount'];
            ?>
            <? if($check>1000000): ?>
        <p>Video ID: <?=$item['id']['videoId'];?></p>
        <p><?=$item['title']?></p>
        <p>Vieews: <?=$videos_view[0]['viewCount']?></p>
        <p>Published at: <?=$item['publishedAt']?></p>
        <p>Author ID: <?=$item['channelId']?></p>
        
            <hr>
            <?endif; ?>
        <? endforeach; ?>
        
    </div>
</body>
</html>