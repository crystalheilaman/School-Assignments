<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<link rel="stylesheet" type="text/css" href="address.css">
<title>Exam 3: Address Book with Categories</title>
<script src="http://code.jquery.com/jquery-1.8.3.min.js"></script>
<script src="address.js"></script>


</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Exam 3: Address Book with Categories</h1>	
	</div> <!--title-->       
    
    
    

    <div id="content"><!--Content-->
    <table>    
    <tr>
         <td> 

         <img src="images/operator.jpg" alt="Switchboard Operator" id="image" class="imageBorder"/>
         </td>
         
         
         <td>            
         <section id="info">   
         
         <script language="JavaScript" type="text/javascript">
		   //loop to read the qualities of the contacts
		   for (var i = 0; i < typeLen; i++) {
			  document.write("<h2>" + type[i].type + " " + "</h2>");
			  document.write("<div id ='details'>");
			  //loop to read the contacts
			  for (var x = 0; x < len; x++) {
				  
				  if(type[i].id == contacts[x].type){
	
				   document.write("<h2>"+contacts[x].Fname +" "+ contacts[x].Lname+"</h2>");
			 		document.write("<div id='details' class=\"hidden\"><strong>Phone: </strong>"+contacts[x].phone +"<br/><br/><img src=\""+contacts[x].image+"\" class=\"changed\" alt=\"contact photo\"/></div>");
			  
				  }//end if
			  } // end contacts for loop
			  document.write("</div>");
		   }//end qualities for loop

   		</script>        
         
         
         
      
         <!--<script>
         <!--
		 
		 for (var i = 0; i<len; i++)
		 {			 
			 document.write("<h2>"+contacts[i].Fname +" "+ contacts[i].Lname+"</h2>");
			 document.write("<div id='details' class=\"hidden\"><strong>Phone: </strong>"+contacts[i].phone +"<br/><br/><img src=\""+contacts[i].image+"\" class=\"changed\" alt=\"contact photo\"/></div>");
		 }
		 	 		 
		 
         </script>   -->
         
         
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