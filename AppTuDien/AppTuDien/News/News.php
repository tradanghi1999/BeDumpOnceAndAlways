<?php

/**
 * News short summary.
 *
 * News description.
 *
 * @version 1.0
 * @author trada
 */
class News
{
    private $conn;
    private $table_name = "news_tbl";
    public $id;
    public $name;
    public $para;
    public $onlink;
    public $offlink;
    public $keywords;
    public $group_id;
    public $search_times;
    public $search_times_client;

    public function __construct($db){
        $this->conn = $db;
    }
    function read(){

        // select all query
        $query = "SELECT * FROM uelapptudien.news_tbl";

        // prepare query statement
        $stmt = $this->conn->query($query);

        // execute query




        return $stmt;
    }
}