<!DOCTYPE html>
<html>
<head>
	<title>Tim</title>
</head>
<body>
	<div class="chatZone">
		
	</div>
	<div class="chatbox">
		<input type="text" name="chat_input">
	</div>
		<?php

		?>

		<form method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
			Name: <input type="text" name="fname">
			<input type="submit">
		</form>

		<?php
		if ($_SERVER["REQUEST_METHOD"] == "POST") {
	    // collect value of input field
			$name = $_POST['fname'];
			if (empty($name)) {
				echo "Name is empty";
			} else {
				echo $name;
			}
		}
		?> 

</body>
</html>

