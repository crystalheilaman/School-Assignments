<!doctype html>
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>CIS 131 - Exam 1</title>
</head>
<script>
<!--

//variables
var strName;

var strChoice = "Please enter 1, 2, 3, or 4.";

//prompt user for their name and store it in a variable. 
function getName()
{
	strName = prompt("Hello!!! What is your name?", "Please enter your name");
	//display variable to screen
	document.getElementById("greeting").innerHTML = "Hello, "+strName+"!";	
}//end function getName

function getChoice()
{
	
	var intChoice = prompt("Which season do you like the best?\n\n(1) Spring\n\n(2) Summer\n\n(3) Fall\n\n(4) Winter", strChoice);	
	
	//document.getElementById("text").style.display = "none";
	
	if (intChoice ==1 && strChoice!="spring.jpg")
	{
		changeImage('images/spring.jpg');
		strChoice = "images/spring.jpg";
	}
	else if(intChoice==2 && strChoice!="images/summer.jpg")
	{
		changeImage('images/summer.jpg');
		strChoice="images/summer.jpg";
	}
	else if(intChoice==3&&strChoice!="images/fall.jpg")
	{
		changeImage('images/fall.jpg');
		strChoice="images/fall.jpg";
	}
	else if(intChoice==4&&strChoice!="images/winter.jpg")
	{
		changeImage('images/winter.jpg');
		strChoice="images/winter.jpg";
	}
	else
	{
		alert("Please choose a different option!");
		getChoice();
	}

/*
	switch (intChoice){
		case 1:
			changeImage('spring.jpg');
						
			break;
		case 2:
			changeImage('summer.jpg');
					
			break;
		case 3:
			changeImage('fall.jpg');
					
			break;
		case 4:
			changeImage('winter.jpg');
						
			break;
		default: 
			break;
	}//end switch	
*/

}//end getChoice

function changeImage(thePicture)
{
	document.getElementById("placeHolder").src = thePicture; 
}//end changeImagege

-->
</script>


<body onload=getName()>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Exam 1</h1>	
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
        <table align="center";>             
		<tr colspan = "3">
        <td><img src="images/seasons.jpg" alt="The four seasons" id="placeHolder" align="center"></td>
        </tr>
        
		<tr colspan = "3"><td style="text-align:center;">
        <p id="greeting"></p>        
        <form name="myForm">
		<input type="button" value="Click Me!" onClick="getChoice()" id="button"/>
		</form></td></tr>                
        </table>
    </div><!--Content-->
    

    
	<footer>
	Created by Crystal Heilaman • CIS 131 • Fall 2014
	</footer>
    


</div><!--Container-->


<!--NAV-->    
    <?php
        include "../menu.html";
    ?>
<!--NAV-->

</body>
</html>