<!doctype html>

<html>
<head>
<meta charset="UTF-8">
    <title>Assignment 11: jQuery Effects</title>
    <link rel="stylesheet" href="main.css">
    <link rel="stylesheet" href="../style.css">
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
	<script src="http://code.jquery.com/jquery-1.8.3.min.js"></script>
    <script src="slide_show.js"></script>
</head>

<body>

<div id="container"><!--Container-->
	
    <div><!--title-->
    <h1>Fishing Slide Show</h1>
	</div> <!--title-->       
    
    

    <div id="content" style="height:500px;"><!--Content-->
    <h2 id="caption" style="text-align:center;">Casting on the Upper Kings</h2>
    <table style="margin:auto">
    <td><img id="slide" src="images/casting1.jpg" alt="" style="margin:auto;" class="imageBorder" >
    <div id="slides" style="margin:auto;"> 
        <img src="images/casting1.jpg" alt="Casting on the Upper Kings">
        <img src="images/casting2.jpg" alt="Casting on the Lower Kings">
        <img src="images/catchrelease.jpg" alt="Catch and Release on the Big Horn">
        <img src="images/fish.jpg" alt="Catching on the South Fork">
        <img src="images/lures.jpg" alt="The Lures for Catching">
    </div>  
    </td>   
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