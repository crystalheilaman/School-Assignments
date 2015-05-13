<!doctype html>
<!-- 
Crystal Heilaman
CIS 131 - Fall 2014
-->


<html>
<head>
<meta charset="utf-8">
<title>JavaScript Array & Style Objects</title>
<link rel="stylesheet" type="text/css" href="../style.css">

<script>
<!--
var myArray = new Array("","images/red.jpg","images/blue.jpg","images/yellow.jpg");
var cChanged = false;
var pChanged = false;
function hideElement()
{
	document.getElementById("header").style.visibility="hidden";
}

function changeColor()
{
	if(cChanged == false)
	{
	document.getElementById("header").style.color = "#FF7ADC";
	cChanged = true;
	}
	else
	{
	document.getElementById("header").style.color = "#7AFF9E";
	cChanged = false;	
	}
}

function showElement()
{
	document.getElementById("header").style.visibility="visible";
}

function moveElement()
{
	if(pChanged == false)
	{
	document.getElementById("header").style.left="100px";
	pChanged = true;
	}
	else
	{
		document.getElementById("header").style.left="0px";
		pChanged = false;
	}
}

-->
</script>

</head>

<script>
<!--
var myVar = setInterval(function(){picTimer()}, 5000);
var counterVar = setInterval(function(){myTimer()}, 1000);
var counter = 1;

function changeImage(randNum){	
	document.getElementById("place").src = myArray[randNum]; 
}//end changeImage


function picTimer(){
	var randNum;
	randNum = Math.floor(Math.random()*3)+1;
	
	changeImage(randNum);
	
}//end picTimer

function myTimer(){
	document.getElementById("timer").innerHTML = counter + " seconds";
	counter++;
	
}//end myTimer

function stopTimer(){
	clearInterval(myVar);
}//end stopTimer

function generateRandom()
{
	randNum = Math.floor(Math.random()*6);
	return randNum; 
}
-->
</script>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<header>
	<h1 id="header" style="position:relative;">I'm a header!!!</h1>
	</header>
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
       <table style="padding:0;"> 
     
        <tr>
        <td cellspan="3" align="center"  style="padding:0;">
        <button onClick="hideElement()" class="ugly">Hide it!</button>
        <button onClick="showElement()" class="ugly">Show it!</button>
        <button onClick="changeColor()" class="ugly">Color it!</button>
        <button onClick="moveElement()" class="ugly">Move it!</button> 
        </td>    
        </tr>

        <tr>
        <td colspan="3" width="850px" height="600px" align="center"  style="padding:0;"><img src="images/rainforest.jpg" alt="Rainforest" id="place" class="imageBorder" onclick="stopTimer()"></td>
        </tr>    
         
        <tr><td colspan="3"  style="padding:0;"><p id="timer" style="text-align:center;"></p></td></tr>
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