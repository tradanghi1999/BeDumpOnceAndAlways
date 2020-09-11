<?php

/**
 * database short summary.
 *
 * database description.
 *
 * @version 1.0
 * @author trada
 */
class database
{
    private $host = "den1.mysql3.gear.host";
    private $db_name = "uelapptudien";
    private $username = "uelapptudien";
    private $password = "Bt892-23s3~g";

    public $conn;

    // get the database connection
    public function getConnection(){

        //$this->conn = null;
        $this->conn = null;
        //$hash = hash('sha2', $this->password);
        try{
            $this->conn = new PDO("mysql:host=" . $this->host . ";dbname=" . $this->db_name, $this->username, $this->password );
            $this->conn->exec("set names utf8");
        }
        catch(PDOException $exception){
            echo "Connection error: " . $exception->getMessage();
        }

        return $this->conn;
    }




//$con->close();

}
