<?php
    //$str = 'Привет мир!!!';
    //file_put_contents('D:\OSPanel\domains\DZFile\test.txt', $str);
    //$str1 = file_get_contents('test.txt');
    //echo nl2br($str1);
    //rename('test.txt', 'D:\OSPanel\domains\DZFile\mir.txt');
    //mkdir('folder');
    //copy('mir.txt', 'D:\OSPanel\domains\DZFile\world.txt');
    //$size = filesize('D:\OSPanel\domains\DZFile\world.txt');
    //echo "Размер файла world.txt: $size байт; 0,0000$size мегабайт; 0,000000$size гигабайт";
    //unlink('D:\OSPanel\domains\DZFile\world.txt');
    /* if (file_exists('world.txt')){
    echo "Файл world.txt существует<br>";
    }else{
    echo "Файл world.txt НЕ существует<br>";
    } 
    if(file_exists('mir.txt')){
        echo "Файл mir.txt существует<br>";
    }else{
        echo "Файл mir.txt НЕ существует<br>";
    }
    mkdir('test');
    //rename('test', 'D:\OSPanel\domains\DZFile\www');
    //rmdir('www');
    $name = ['first','second','third'];
    foreach($name as $item){
        mkdir("D:\OSPanel\domains\DZFile\\test\\$item");
    } */
    //$files1 = scandir('D:\OSPanel\domains\DZFile\test');
    //print_r($files1);
    /* function DirFilesR($dir){     
    $handle = opendir($dir) or die("Can't open directory $dir");  
    $files = Array();  
    $subfiles = Array();  
    while (false !== ($file = readdir($handle)))  
    {  
      if ($file != "." && $file != "..")  
      {  
        if(is_dir($dir."/".$file))  
        {   
          $subfiles = DirFilesR($dir."/".$file);   
          $files = array_merge($files,$subfiles);  
        }  
        else 
        {  
          $files[] = $dir."/".$file;  
        }  
      }  
    }  
    closedir($handle);  
    return $files;  
    }
    print_r (DirFilesR('D:\OSPanel\domains\DZFile\test')); */
    /* function GetContent($dir){
        $files = Array();
        $handle = opendir($dir);
        while(false!==($file = readdir($handle))){
            if($file != "." && $file != "..") {
                if(is_file($dir."/".$file)){
                    $files[] = $dir."/".$file;
                }
                
            }
        }
        
        $tmp='';
        foreach($files as $item){
            $tmp = file_get_contents($item);
            echo $tmp.'<br>';
            $tmp = 0;
        }
        closedir($handle); 
    }
    GetContent('D:\OSPanel\domains\DZFile\test'); */
    /* function GetTxt($dir){
        $files = Array();
        $handle = scandir($dir);
        foreach($handle as $item){
            if(is_file($dir."/".$item) && preg_match('#.txt$#',$item)){
                $files[]=$item;
            }
           
        }
        print_r($files);
    }
    GetTxt('D:\OSPanel\domains\DZFile\test'); */
    /* function fullTrack($dir){
        $files = Array();
        $handle = scandir($dir);
        foreach($handle as $item){
            if(is_file($handle."/".$item)&&preg_match('#.txt$#',$item)){
                $text=file_get_contents($handle."/".$item);
                file_put_contents($handle."/".$item, 'D:\OSPanel\domains\DZFile\test1'."/".$item.PHP_EOL.$text);
            }
        }
    }
    fullTrack('D:\OSPanel\domains\DZFile\test'); */
    /* function showAll($dir){
        $files = Array();
        $handle = scandir($dir);
        unset($handle[0],$handle[1]);
        foreach($handle as $item){
            if(is_dir($handle."/".$item)){
                $str = "/".$item;
                $files[$item]=showAll($str);
            }
        }
        return $files;
    }
    print_r(showAll('D:\OSPanel\domains\DZFile\test')); */
    
?>