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




function addressBook(Fname, Lname, phone, image, type)
{
	this.Fname = Fname;
	this.Lname = Lname;
	this.phone = phone;
	this.image = image;
	this.type = type;
	
}

function contactType(id, type)
{
	this.id = id;
	this.type = type;
}

 // Instantiate 3 instances of addressType
var type = new Array();
type[0] = new contactType("0","President");
type[1] = new contactType("1","First Lady");
type[2] = new contactType("2","Other");

var typeLen = type.length;

//instantiate instances of AddressBook object
var contacts = new Array();
contacts[0] = new addressBook ("Michelle","Obama","555-555-5555","images/michelle.jpg","1");
contacts[1] = new addressBook ("Hillary","Clinton","111-111-1111","images/hillary.jpg","1");
contacts[2] = new addressBook ("Bill","Clinton","222-222-2222","images/bill.jpg","0");
contacts[3] = new addressBook ("George W.","Bush","333-333-3333","images/bush.jpg","0");
contacts[4] = new addressBook ("Richard", "Nixon","444-444-4444","images/nixon.jpg","0");
contacts[5] = new addressBook ("Steve", "Urkel","777-777-7777","images/urkel.jpg","2");

var len = contacts.length;


