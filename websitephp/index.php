<?php
    include("database.php");
?>
<!DOCTYPE html>

<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        
        <style>
            /*internal css as external css will not work*/
            

            * {
                 /*
                 reset the webpage layout
                */
                margin: 0;
                padding: 0;
            }

            .registration-container{
                margin-left: 38rem;
                margin-right: 38rem;
                width: 300px;
                height: 200px;
                padding: 1px;
                display:flex;
                box-sizing: border-box;
                align-items: start;
                
            }
            .registration-content{
                border: 2px solid black;
                height: 100%;
                padding: 1rem;
                padding-top: 10px;
                border-radius: 20px;
                box-sizing: border-box;
                justify-content: center;
                display:flex;
                align-items: start;
            }
            .button{
                background-color: lightgreen;
                border-style: none;
                padding: 2px;
                border-radius: 5px;
                color: white;
            }
            input{
                border: 0.5px solid grey;
                border-radius: 3px;
            }
        </style>
    </head>
    <body>
        <!--[if lt IE 7]>
            create a div to contain the form
        <![endif]-->
        <div class="registration-container">
        <!--[if lt IE 7]>
            create a div to contain the form content
        <![endif]-->
            <div class="registration-content">
            <!--[if lt IE 7]>
                create a form with action and method along with its input types
            <![endif]-->
                <form action = "<?php htmlspecialchars($_SERVER["PHP_SELF"])?>" method="post">
                    <h2>Registration</h2><br/>
                    First name:<br/>
                    <input type = "text" name = "fname" placeholder="Enter your first name"><br/>
                    Last name:<br/>
                    <input type = "text" name = "lname" placeholder="Enter your last name"><br/>
                    Email:<br/>
                    <input type = "email" name = "mail" placeholder="Enter your email"><br/>
                    <input class = "button" type = "submit" name = "submit" value = "Login"><br/>
                </form>
            </div>
        </div>
    </body>
</html>
<?php

    if($_SERVER["REQUEST_METHOD"] == "POST"){

        $fname = $_POST["fname"];
        $lname = $_POST["lname"];
        $email = $_POST["mail"];

        /*
            if statements validate if fields are entered
        */
        if(empty($fname)){
            echo "Please enter a first name";
        }
        elseif(empty($lname)){
            echo "please enter a last name";
        }
        elseif(empty($email)){
             echo "please enter a email";
        }
        else{
            /*
            all fields are validated so insert statement will insert data to the database
            */
            $sql = "INSERT INTO registerusers (fname, lname, email) 
                    VALUES ('$fname', '$lname', '$email')";
            
            try{
                /*excpetion handling*/
                    mysqli_query($conn, $sql);
                    echo "You are  registered";

            }catch(mysqli_sql_exception){
                echo "error";
            }
        }
    }

    mysqli_close($conn);
    
?>



