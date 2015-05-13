<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>Basic JavaScript
</title>
<!-- //Crystal Heilaman
//08/24/14
//CIS 131-101-->
</head>

<body onload="alert('What did you say?!')" onunload="alert('I will miss you!!')";>


<div id="container"><!--Container-->
	
    <div><!--title-->
		<h1>Super String Monster!</h1>
	</div> <!--title-->       
    
    

    <div id="content" style="height:300px;"><!--Content-->
        
        <image src="images/monster.png" alt="String Monster" style="float:left;"> 
        <p>
        <h4>This monster's name is Henry.  He is the Super String Monster.  He takes your strings and puts them together.  <br/><br/>Here are your results: <br/></h4>
        </p>
   
    <script>
		<!--
		//prompt user to enter number
		var strOne = prompt("Please enter some words","");
		var strTwo = prompt("Please enter some words","");
		
		
		//display the string
		document.write("The string you entered is: " + strOne + " " + strTwo + ".");
		-->
	</script>
	
	<br/><br/><br/>
    
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