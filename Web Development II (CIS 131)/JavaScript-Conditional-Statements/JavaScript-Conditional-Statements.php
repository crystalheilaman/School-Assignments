<!doctype html>
<!-- 
Crystal Heilaman
CIS 131 - Fall 2014
-->

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>JavascriptFunctions</title>
</head>

<script>
<!--
var myVar = setInterval(function(){picTimer()}, 5000);
var counterVar = setInterval(function(){myTimer()}, 1000);
var counter = 1;

function changeImage(thePicture){
	document.getElementById("place").src = thePicture; 
}//end changeImage


function picTimer(){
	var randNum;
	randNum = Math.floor(Math.random()*3)+1;
	
	switch (randNum){
		case 1:
			changeImage('images/red.jpg');
			break;
		case 2:
			changeImage('images/blue.jpg');
			break;
		case 3:
			changeImage('images/yellow.jpg');
			break;
		default:
			break;		
	}//end switch
}//end picTimer

function myTimer(){
	document.getElementById("timer").innerHTML = counter + " seconds";
	counter++;
}//end myTimer

function stopTimer(){
	clearInterval(myVar);
}//end stopTimer

-->
</script>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>JavaScript Conditional Statements</h1>	
	</div> <!--title-->       
        
    <div id="content"><!--Content-->
        <table>      

        <tr>
            <td colspan="3" width="850px" height="600px" align="center"><p id="timer" style="text-align:center; padding:-10px;">FROGS!!!</p>
            <br/>
            <img src="images/rainforest.jpg" alt="Rainforest" id="place"  class="imageBorder" onclick="stopTimer()"></td>
        </tr>
        
        <tr>
            <td align="left"><img src="images/thumbred.jpg" alt="Red Frog" class="imageBorder"></td>
            <td align="center"><img src="images/thumbblue.jpg" alt="Blue Frog" class="imageBorder"></td>
            <td align="right"><img src="images/thumbyellow.jpg" alt="Yellow Frog" class="imageBorder"></td>        
        </tr>
        
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