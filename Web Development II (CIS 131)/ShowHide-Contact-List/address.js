$(function() {
	$("#info h2").toggle(
		function() {
			$(this).toggleClass("minus");
		    $(this).next().show();			
	    },
	    function() {
	        $(this).toggleClass("minus");
	        $(this).next().hide();			
	    }
    ); // end toggle	
});



function addressBook(Fname, Lname, phone, email, image)
{
	this.Fname = Fname;
	this.Lname = Lname;
	this.phone = phone;
	this.email = email;
	this.image = image;

	
}

//instantiate instances of AddressBook object
var contacts = new Array();
contacts[0] = new addressBook ("Lucille","Ball","555-555-5555", "lball@cis131.net", "images/lucilleball.jpg");
contacts[1] = new addressBook ("John","Wayne","111-111-1111","jwayne@cis131.net","images/johnwayne.jpg");
contacts[2] = new addressBook ("Marilyn","Monroe","222-222-2222","mmonroe@cis131.net","images/marilynmonroe.jpg");
contacts[3] = new addressBook ("Frank","Sinatra","333-333-3333", "fsinatra@cis131.net","images/franksinatra.jpg");
contacts[4] = new addressBook ("Elizabeth", "Taylor","444-444-4444", "etaylor@cis131.net", "images/elizabethtaylor.jpg");

var len = contacts.length;


