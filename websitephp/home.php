<?php
    session_start(); 
?>
<!DOCTYPE html>

<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="">
    </head>
    <body>
        This is the home page <br />
        <form action = "home.php" method = "post">
            <input type = "submit" name = "logout" value="logout" />
        </form>
    </body>
</html>
<?php
    echo $_SESSION["username"] . "<br>";
    echo $_SESSION["password"] . "<br>";

    if(isset($_POST["logout"])){
        //ends the session
        session_destroy();
        header("Location: index.php");
    }
?>