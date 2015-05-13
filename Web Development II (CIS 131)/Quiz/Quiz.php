<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>Assignment 8: Let's Make A Quiz</title>

<script>
<!--
//global variables for answer status
var q1 = false;
var q2 = false;
var q3 = false;
var rightAnswers = 0;
var allSelected = true;

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
	else if (selection == "b")
	{
		q1 = true;
		rightAnswers ++;
	}
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
	else if (y.value == "4")
	{
		q2 = true;
		rightAnswers ++;
	}
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
	else if (z.value == "hamsandwich")
	{
		q3 = true;
		rightAnswers ++;
	}
	//end validation for selectBox		
  
		
	if (allSelected)
	{		
		document.getElementById("results").style.color = "green";
		document.getElementById("results").style.display = "block";	
		document.getElementById("results").innerHTML="You got "+rightAnswers+" out of 3 correct!";
	}
	
	return false;
}//end getSelected



-->
</script>


</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Let's Take a Quiz!</h1>	
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
        <!--radio buttons, text box, select list, submit button-->
        <form name="quiz" class="formStyle">
        <span id="q1">
        What color is the sky? 
        </span>
        <br/>
        <span id="rads">
        <input type="radio" name="radios" value="r">Red</input>
        <input type="radio" name="radios" value="b">Blue</input>
        <input type="radio" name="radios" value="pb">Peanut Butter</input>
        </span>
        <br/>
        
        <br/>
        <span id="q2">
        What is 2+2?
        </span>
        <input type="text" name="question" id="textBox"></input>
        <br/>
        
        <br/>
        <span id="q3">
        Which one is NOT an animal?
        </span>
        <select name="question" id="selectBox">
        <option value="">Select One</option>
        <option value="kangaroo">Kangaroo</option>
        <option value="rabbit">Rabbit</option>
        <option value="donkey">Donkey</option>
        <option value="platypus">Platypus</option>
        <option value="hamsandwich">Ham Sandwich</option>
        </select>
        <br/>
        
        <br/>
        <input type="submit" class = "button" onClick="return getSelected(this.form)"/>
        <div id="results" style="display:none;font-style:italic;text-align:center;">
        <!--display results on page-->
        Results
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