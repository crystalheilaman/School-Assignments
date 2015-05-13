<!doctype html>

<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="../style.css">
<title>Assignment 9: Address Book</title>
<style>

td
{
	padding:15px;
	width:300px;
}

table
{
	margin:auto;
}

.changed
{
	border:1px solid #dddddd;
	box-shadow: black 0 0px 20px -1px;	
}

#select
{
    color: #000000;
    padding: 5px 20px 5px 5px;    
    border: 1px solid #CCCCCC;
    height: 25px;
    line-height:20px;
    outline: 0 none;
    box-shadow: inset 1px 1px 2px gray;
    border-radius: 4px;	
    margin:auto;
    font-family: "Helvetica Neue", Helvetica, Arial, sans-serif;
}


</style>



<script>
<!--

function addressBook(Fname, Lname, phone, email, image)
{
	this.Fname = Fname;
	this.Lname = Lname;
	this.phone = phone;
	this.email = email;
	this.image = image;
	this.showContacts = showContacts;
	
}

//instantiate instances of AddressBook object
var contacts = new Array();
contacts[0] = "Select Contact";
contacts[1] = new addressBook ("Lucille","Ball","555-555-5555", "lball@cis131.net", "images/lucilleball.jpg");
contacts[2] = new addressBook ("John","Wayne","111-111-1111","jwayne@cis131.net","images/johnwayne.jpg");
contacts[3] = new addressBook ("Marilyn","Monroe","222-222-2222","mmonroe@cis131.net","images/marilynmonroe.jpg");
contacts[4] = new addressBook ("Frank","Sinatra","333-333-3333", "fsinatra@cis131.net","images/franksinatra.jpg");
contacts[5] = new addressBook ("Elizabeth", "Taylor","444-444-4444", "etaylor@cis131.net", "images/elizabethtaylor.jpg");

var len = contacts.length;

function showContacts()
{
	
	var info="";
	info+= "Name: " + this.Fname + " " + this.Lname + "<br/>";
	info+= "";
	info+= "Phone: " + this.phone + "<br/>";
	info+= "";
	info+= "Email: " + this.email + "<br/>";
	
	document.getElementById("info").innerHTML = info;
	document.getElementById("image").src= this.image;
	document.getElementById("image").setAttribute("class","changed");
}


-->
</script>


</head>

<body>


<div id="container"><!--Container-->
	
    <div><!--title-->
	<h1>Address Book</h1>	
	</div> <!--title-->       
    
    

    <div id="content"><!--Content-->
    
    <table style="padding:10px;">
    
    <tr>
        <td colspan="2" style="color:#575757;">  
            <form name="contactsForm" id="contactsForm" >
            <strong>Select name to view information:</strong> 
            <select name="contactsName" id="select" onchange="contacts[this.selectedIndex].showContacts();this.selectedIndex=0;">
            <script language="JavaScript" type="text/javascript">
            <!--
            
              for (var i = 0; i < len; i++) 
              {
                if(i == 0) document.write("<option>" + contacts[i]) + "</option>";
                else 
				document.write("<option>" + contacts[i].Fname + " " +contacts[i].Lname) + "</option>";
              }
              
            //-->
            </script>
            </select>
            </form>
        </td>
    </tr>
    
     <tr>
         <td> 
         <img src="images\addressbook.png" alt="address book" id="image"/>
         </td>
         
         
         <td id="info" style="color:#575757;">         
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