<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<link rel="stylesheet" type="text/css" href="address.css">
<title>Assignment 10: Show/Hide Contact List</title>
<script src="http://code.jquery.com/jquery-1.8.3.min.js"></script>
<script src="address.js"></script>


</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Contact List</h1>	
	</div> <!--title-->       
    
    
    

    <div id="content"><!--Content-->
    <table>    
    <tr>
         <td> 

         <img src="images/operator.jpg" alt="Switchboard Operator" id="image" class="imageBorder"/>
         </td>
         
         
         <td>            
         <section id="info">   
      
         <script>
         <!--
		 
		 for (var i = 0; i<len; i++)
		 {			 
			 document.write("<h2>"+contacts[i].Fname +" "+ contacts[i].Lname+"</h2>");
			 document.write("<div id='details' class=\"hidden\"><strong>Phone: </strong>"+contacts[i].phone +"<br/><strong>Email: </strong>"+ contacts[i].email+ "<br/><br/><img src=\""+contacts[i].image+"\" class=\"changed\" alt=\"contact photo\"/></div>");
		 }
		 	 		 
		 -->
         </script>   
         </section> <!--info--> 

         </td>
     
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