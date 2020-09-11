<?php

/**
 * Group short summary.
 *
 * Group description.
 *
 * @version 1.0
 * @author trada
 */
class Group
{
    private $conn;
    private $table_name = "group_tbl";
    public $group_id;
    public $group_name_vi;
    public $group_name_en;
    public $search_times;
    public $search_times_client;
    public function __construct($db){
        $this->conn = $db;
    }
    function read(){

        // select all query
        $query = "SELECT * FROM uelapptudien.group_tbl";

        // prepare query statement
        $stmt = $this->conn->query($query);

        // execute query




        return $stmt;
    }

}