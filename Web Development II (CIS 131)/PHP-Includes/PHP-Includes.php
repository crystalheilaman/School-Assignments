<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>JavaScript Form Validation</title>

<script language="JavaScript" type="text/javascript">
<!--
 function checkForm()
    {        
	  var items = document.getElementById('myForm').elements;	
	  var returnValue = true;  	
	  for(var i = 0; i < items.length; i++)
        {						
			document.getElementById(items[i].name).style.backgroundColor="white";
			document.getElementById("errorMessage").style.display="none";
			
           	if(items[i].value.length < 1)
				{	
					for(var j = 0; j < items.length; j++)
					{						
						if(items[j].value.length < 1)
							{	
								document.getElementById("errorMessage").style.display="inline";						
								document.getElementById(items[j].name).style.backgroundColor="#FFB2B2";	
							}//end if
					}//end for
					return false;														
				}//end if									
        } //end for	
     }//end checkForm

	 
 
//-->
</script>

</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Contact information</h1>
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
    <form name="myForm" id="myForm" action="Thank-You.php" class="formStyle" method="post">       
        <h4>All fields are required.</h4>
        <table>
        <tr>
        <td>Name:</td>
        <td><input type="text" name="Name" id="Name" placeholder="Full Name" style="height:20px;line-height:15px;width: 80%;padding: 5px 20px 5px 5px;"/></td>
        </tr>
        
        <tr>
        <td>Email Address:</td>
        <td><input type="text" name="Email_Address" id="Email_Address" placeholder="Enter Email" style="height:20px;line-height:15px;width: 80%;padding: 5px 20px 5px 5px;"/></td>
        </tr>
        
        <tr>
        <td>Phone Number:</td>
        <td><input type="text" name="Phone_Number" id="Phone_Number" placeholder="Enter Phone Number" style="height:20px;line-height:15px;width: 80%;padding: 5px 20px 5px 5px;"/></td>
        </tr>
        
        </table>
        <input type="submit" value="Submit" class = "button" onclick="return checkForm(this.form);" />
        
        <br/>
        <div id="errorMessage" style="display:none; color:red">
        * required fields are missing.
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