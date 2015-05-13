using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ParkingSystem : Form
    {
        public ParkingSystem()
        {
            InitializeComponent();
        }
        
        //create 25 parking spots in a list
        List<Ticket> parkingSpots = new List<Ticket>();     
        int newTicket = 1;
        
        private void bttnEnter_Click(object sender, EventArgs e)
        {
            //check to see if all parking spots are full
            //if not, assign a ticket number

            if(parkingSpots.Count < 25)
            {
                DateTime currentTime = (DateTime.Now);
                //provide ticket number and store in list location
                parkingSpots.Add(new Ticket(newTicket, currentTime));
                MessageBox.Show("Ticket Number: " + newTicket + ".\n\nEntry time: "
                    + currentTime + ". \n\nYou may proceed.");
                newTicket ++;
            }
            else
            {
                MessageBox.Show("I'm sorry, this garage is full. \n Please try again later.");
            }

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //show the box where user can enter data
            //hide all the other boxes
        }

        private void bttnGenerateTicket_Click(object sender, EventArgs e)
        {
            //calculate fee and display to user
            decimal cost = Ticket.CalculateCharge();
            MessageBox.Show("Your total is {0:C}. \n\nThank you for using the Parking System!\n\n Have a great day!");
            
            //hide data box, and show the other options again. 
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            OutputBox.Items.Add(parkingSpots);
        }




    }//end parking system
}//end namespace
