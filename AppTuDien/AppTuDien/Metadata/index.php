<?php
// required headers
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

// database connection will be here// include database and object files
include_once '../config/database.php';

include_once 'Version.php';

// instantiate database and product object
$database = new Database();
$db = $database->getConnection();

// initialize object
$version = new Version($db);


// read products will be here
// query products
$stmt_version = $version->read();
$newss_arr=array();
$row_version = $stmt_version->fetch(PDO::FETCH_ASSOC);
if(!$row_version)
{
     http_response_code(404);

    // tell the user no products found
    echo json_encode(
        array("message" => "No products found.")
    );
    return;
}
    extract($row_version);
    $newss_arr["word_meta_data"]= json_decode($message);
    $newss_arr["news_meta_data"]= json_decode($message);
    $newss_arr["group_meta_data"]= json_decode($message);
    // set response code - 200 OK
    http_response_code(200);
    // show products data in json format
    echo json_encode($newss_arr);


