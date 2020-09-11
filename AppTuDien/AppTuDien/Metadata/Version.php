<?php

/**
 * Version short summary.
 *
 * Version description.
 *
 * @version 1.0
 * @author trada
 */
class Version
{
    private $conn;
    private $table_name = "log_tbl";

    // object properties
   
    public $message;
    public $mes_time;

    public function __construct($db)
    {
        $this->conn = $db;
    }

    function read()
    {

        // select all query
        $query = "  select 	message,
		                    max(mes_time)
                    from
                    (

	                    SELECT 	id as id,
			                    message as message,
			                    mes_type as mes_type,
			                    mes_time as mes_time
	                    FROM uelapptudien.log_db
	                    where 	mes_type='update_mes'
                    )
                    as tbl_log";

        // prepare query statement
        $stmt = $this->conn->query($query);

        // execute query
        return $stmt;
    }
}
