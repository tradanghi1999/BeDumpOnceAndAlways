<?php

include_once 'OBJ/Conversation.php';

include_once 'Config/config.php';

$con = new Con(Config::$log_dir);

$con->write();