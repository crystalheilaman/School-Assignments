<!doctype html>
<!--
Crystal Heilaman
Fall 2014
CIS131
This is the home page used to access all of my assignments
-->
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="style.css">
<script src="http://code.jquery.com/jquery-1.8.3.min.js"></script>
<script src="javaScript.js"></script> 
<title>Homework Assignments CIS131</title>
</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>CIS 131 - Fall 2014</h1>	
	</div> <!--title-->       

    <div id="expander" style="font-size:14px;"><!--Content-->
		<img src="images/image.gif" alt="Home Image" style="float:right;margin:10px;"/>

        
        <ul>
        <h3>Assignments</h3>
        <span class="hidden">
        <li><a href="CSS-Review/CSS-Review.php">Assignment 1: CSS Review</a></li>
        <li><a href="Basic-Java-Script/Basic-Java-Script.php">Assignment 2: Basic JavaScript</a></li>
        <li><a href="JavaScriptFunctions/JavaScriptFunctions.php">Assignment 3: JavaScript Functions</a></li>
        <li><a href="JavaScript-Conditional-Statements/JavaScript-Conditional-Statements.php">Assignment 4: Timers & Conditional Statements</a></li>
        <li><a href="JavaScript-Array-Style-Objects/JavaScript-Array-Style-Objects.html">Assignment 5: JavaScript Array & Style Objects</a></li>            
        <li><a href="JavaScript-Form-Validation/JavaScript-Form-Validation.php">Assignment 6: JavaScript Form Validation</a></li>
        <li><a href="PHP-Includes/PHP-Includes.php">Assignment 7: PHP Includes</a></li>
        <li><a href="Quiz/Quiz.php">Assignment 8: Let's Make a Quiz</a></li> 
        <li><a href="Address-Book/Address-Book.php">Assignment 9: Address Book</a></li>   
        <li><a href="ShowHide-Contact-List/ShowHide-Contact-List.php">Assignment 10: Show/Hide Contacts</a></li> 
        <li><a href="jQuery-Effects/jQuery-Effects.php">Assignment 11: jQuery Effects</a></li> 
        <li><a href="DOM-manipulation/DOM-manipulation.php">Assignment 12: jQuery DOM Manipulation</a></li> 
        <li><a href="Plugins/Plugins.php">Assignment 13: Plug-ins</a></li> 
        

        </span>
        
        <h3>Projects</h3>
        <span class="hidden">
        <li><a href="Midterm/Midterm.html">Midterm Project: The Great Race!</a></li>
         </span>
         
        <h3>Exams</h3> 
        <span class="hidden">  
        <li><a href="Exam1/Exam1.php">Exam 1: Changing Seasons</a></li>
        <li><a href="Exam2/Exam2.php">Exam 2: Which Disney Princess Are You?</a></li>  
        <li><a href="Exam3/Exam3.php">Exam 3: Address Book with Categories</a></li>  
        </ul>
        </span>
    </div><!--Content-->
    
<hr style="width:100%; visibility:hidden;"/>
    
	<footer>
	Created by Crystal Heilaman • CIS 131 • Fall 2014 
	</footer>
    


</div><!--Container-->

<!--NAV-->    
    <?php
        include "menu.html";
    ?>
<!--NAV-->

</body>
</html>