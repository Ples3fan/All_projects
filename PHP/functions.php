<?php
    function clean_data($str) {
        return strip_tags(trim($str));
    }

    function getIdVideos($apikey, $search, $limit){
        $json_result = file_get_contents("https://www.googleapis.com/youtube/v3/search?part=snippet&q=$search&type=video&maxResults=$limit&key=$apikey");
        $obj = json_decode($json_result);
        foreach($obj->items as $item) {
            $item->id->videoId."<br>";
        } 

    }

    function insert_date($title, $view, $date, $author, $img) {
        global $db;
        $query = "INSERT INTO videos (
            title,
            view,
            date,
            author,
            img
            ) 
        VALUES (
            '%s',
            '%s',
            '%s',
            '%s',
            '%s'
        )";
        $query = sprintf($query,
                    mysqli_real_escape_string($db, $title),
                    mysqli_real_escape_string($db, $view),
                    mysqli_real_escape_string($db, $date),
                    mysqli_real_escape_string($db, $author),
                    mysqli_real_escape_string($db, $img)
                );
        mysqli_query($db, $query);

      }
?>