<?php

/**
 * Dir short summary.
 *
 * Dir description.
 *
 * @version 1.0
 * @author trada
 */
class Dir
{
    private $dir;
    public function __construct($dir){
        $this ->dir = $dir;

    }
    function getLogDir()
    {

        if(file_exists(basename(__DIR__).'dir.json'))
        {
            $json = file_get_contents('dir.json');
            $dir = json_decode($json);
            return $dir->log;
        }
    }
}
?>