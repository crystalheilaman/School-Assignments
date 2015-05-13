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

function changeImage(thePicture){
	document.getElementById("place").src = thePicture; 
}	

-->
</script>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Poison Dart Frogs</h1>
	</div> <!--title-->   
    
    <div id="content"><!--Content-->
       <table> 
        <tr>
            <td colspan="3" width="850px" height="600px" align="center"><img src="images/rainforest.jpg" id="place" alt="RainForest" class="imageBorder"></td>
        </tr>
        
        <tr>
            <td align="left"><img src="images/thumbred.jpg" class="imageBorder" alt="Red Frog" onClick="changeImage('images/red.jpg')"></td>
            <td align="center"><img src="images/thumbblue.jpg" alt="Blue Frog" class="imageBorder" onClick="changeImage('images/blue.jpg')"></td>
            <td align="right"><img src="images/thumbyellow.jpg" alt="Yellow Frog" class="imageBorder" onClick="changeImage('images/yellow.JPG')"></td>        
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