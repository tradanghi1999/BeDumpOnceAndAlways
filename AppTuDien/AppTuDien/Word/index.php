<?php
// required headers
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

// database connection will be here// include database and object files
include_once '../config/database.php';
include_once 'word.php';
include_once '../metadata/Version.php';

// instantiate database and product object
$database = new Database();
$db = $database->getConnection();

// initialize object
$word = new Word($db);
$version = new Version($db);


// read products will be here
// query products
$stmt_version = $version->read();
$words_arr=array();
$row_version = $stmt_version->fetch(PDO::FETCH_ASSOC);
if($row_version)
    extract($row_version);
$words_arr["meta_data"]= json_decode($message);



$stmt_word = $word->read();
$num = $stmt_word->rowCount();

// check if more than 0 record found
if($num>0){

    // products array

    $words_arr["records"]=array();

    // retrieve our table contents
    // fetch() is faster than fetchAll()
    // http://stackoverflow.com/questions/2770630/pdofetchall-vs-pdofetch-in-a-loop
    while ($row_word = $stmt_word->fetch(PDO::FETCH_ASSOC)){
        // extract row
        // this will make $row['name'] to
        // just $name only
        extract($row_word);

        $word_item=array(
            "id" => $id,
            "group_id" => $group_id,
            "vi_word" => $vi_word,
            "en_word" => $en_word,
            "search_times" => $search_times,
            "search_times_client" => $search_times_client
        );

        array_push($words_arr["records"], $word_item);
    }

    // set response code - 200 OK
    http_response_code(200);

    // show products data in json format
    echo json_encode($words_arr);
}

// no products found will be here
else{

    // set response code - 404 Not found
    http_response_code(404);

    // tell the user no products found
    echo json_encode(
        array("message" => "No products found.")
    );
}