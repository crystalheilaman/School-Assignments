<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>Exam 2: FaceBook Quiz</title>

<script>
<!--
//global variables for answer status
var q1 = false;
var q2 = false;
var q3 = false;
var allSelected = true;

var a1, a2, a3;

//check to make sure all questions are answered. 
function getSelected()
{	
	//reset 
	if (allSelected ==false)
	{
		document.getElementById("q1").style.color="black";
		document.getElementById("q2").style.color="black";
		document.getElementById("q3").style.color="black";
		document.getElementById("results").style.display = "none";
		allSelected = true;
		rightAnswers = 0
	}


	//validation and data collection for radio buttons
	var selection="";
	var len=document.quiz.radios.length;
	var x = document.getElementsByName("radios");

	
	for (i=0;i<len;i++)
	{
		if(x[i].checked)
		{
			selection=x[i].value;						
		}//end if
	}//end for
	
	if (selection == "")
	{				
		document.getElementById("q1").style.color="red";
		
		document.getElementById("results").style.display = "block";
		document.getElementById("results").style.color = "red";
		document.getElementById("results").innerHTML="Please answer all questions!";
		allSelected = false;
	}
	
	a1=selection;

	//end validation for radio buttons
	
	
	//validation for textbox
	var y = document.getElementById("textBox");
	
	if (y.value=="")
	{
		document.getElementById("q2").style.color="red";
		
		document.getElementById("results").style.display = "block";
		document.getElementById("results").style.color = "red";
		document.getElementById("results").innerHTML="Please answer all questions!";
		allSelected = false;
	}	
	a2 = y.value;
	//end validation for textbox
	
	//validation for selectBox	
	var z = document.getElementById("selectBox");
	
	if (z.value=="")
	{
		document.getElementById("q3").style.color="red";
		
		document.getElementById("results").style.display = "block";
		document.getElementById("results").style.color = "red";
		document.getElementById("results").innerHTML="Please answer all questions!";
		allSelected = false;
	}	
	a3 = z.value;
	//end validation for selectBox		
  
		
	if (allSelected)
	{		
		document.getElementById("results").style.color = "green";
		document.getElementById("results").style.display = "block";	
		document.getElementById("results").innerHTML="Your answers: <br/>Your favorite place to take a nap is in a " + a1 + ". <br/>Your age is "+a2+", and "+a3+".";
		returnAnswer();
	}
	
	return false;
}//end getSelected

function returnAnswer()
{
	//create array of images
	var imageArray = new Array();
	
	//fill array
	for(var i=0;i<7;i++)
	{
		imageArray[i] = new Image();
		imageArray[i].src = "images/princess"+[i]+".jpg";
	}
	
	//create random number between 1 & 7
	var imgNum = Math.floor(Math.random()*7);
	
	document.getElementById("imageHolder").innerHTML="<img src='"+imageArray[imgNum].src+"'/>";
	
	
}



-->
</script>


</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>What Disney Character are you?</h1>	
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
        <!--radio buttons, text box, select list, submit button-->
        <form name="quiz" class="formStyle">
        <span id="q1">
        Where is your favorite place to take a nap? 
        </span>
        <br/>
        <span id="rads">
        <input type="radio" name="radios" value="bed">Bed</input>
        <input type="radio" name="radios" value="tree">Tree</input>
        <input type="radio" name="radios" value="well">Well</input>
        </span>
        <br/>
        
        <br/>
        <span id="q2">
        How old are you?
        </span>
        <input type="text" name="question" id="textBox"></input>
        <br/>
        
        <br/>
        <span id="q3">
        Who is your best friend?
        </span>
        <select name="question" id="selectBox">
        <option value="">Select One</option>
        <option value="your dog is your best friend">My Dog</option>
        <option value="your bf/gf is your best friend">My gf/bf</option>
        <option value="your mom/dad is your best friend">My mom/dad</option>
        <option value="your best friend is your best friend">My best friend, duh!</option>
        <option value="you hate people">I hate people</option>
        </select>
        <br/>
        
        <br/>
        <input type="submit" class = "button" onClick="return getSelected(this.form)"/>
        <input type="button" class = "button" onClick="window.location.href='thankyou.php'" value="End Game" style="float:right;"/>   
        
        <div id="results" style="display:none;font-style:italic;text-align:center;">
        <!--display results on page-->
        Results             
        </div>
        <div id="imageHolder" style="padding:10px;"> 
        </div>   
        </form>

     
        
        

        
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