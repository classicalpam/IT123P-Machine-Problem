<?php 

include_once('connect.php');
$username = $_GET['username'];
$password = $_GET['password'];

$queryCommand = "INSERT INTO usertable (username, password) VALUES ('$username','$password')";
$result = mysqli_query($con,$queryCommand));
if ($result) {
	echo "Message Sent! Thank You!";
} else {
	echo "Unable to register account.";
}
$con-> close();
?>