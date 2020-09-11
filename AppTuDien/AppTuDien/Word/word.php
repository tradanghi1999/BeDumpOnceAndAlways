<?php
class Word{

    // database connection and table name
    private $conn;
    private $table_name = "word_tbl";

    // object properties
    public $id;
    public $group_id;
    public $vi_word;
    public $en_word;
    public $search_times;
    public $search_times_client;


    // constructor with $db as database connection
    public function __construct($db){
        $this->conn = $db;
    }
    function read(){

    // select all query
        $query = "SELECT * FROM uelapptudien.word_tbl";

        // prepare query statement
        $stmt = $this->conn->query($query);

    // execute query




    return $stmt;
}
}
