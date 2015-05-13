using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;//needed for xml classes

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
        List<Ticket> ticketArchive = new List<Ticket>();       
        int availableSpots = 25;

        int newTicket = 1;
        
        private void bttnEnter_Click(object sender, EventArgs e)
        {
            //check to see if all parking spots are full
            //if not, assign a ticket number

            if (availableSpots > 0)
            {
                DateTime currentTime = DateTime.Now;
                //DateTime currentTime = Convert.ToDateTime(12+":"+34);
                
                //provide ticket number and store in list location
                parkingSpots.Add(new Ticket(newTicket, currentTime));

                DialogResult result = MessageBox.Show("The cost to park in this garage is a minimum of $2.00 for up to 3 hours." +
                    "\n\nEach additional hour (or part thereof) will be an additional $0.50. \n\nThe maximum charge for any 24-hour period is $10.00.", "", MessageBoxButtons.OKCancel);

                if (result.Equals(DialogResult.OK))
                {
                    MessageBox.Show("Ticket Number: " + newTicket + ".\n\nEntry time: "
                       + currentTime.ToString("HH:mm") + ". \n\nYou may proceed.");
                    newTicket++;
                    availableSpots--;

                    listBox.Items.Clear();
                    foreach (Ticket ps in parkingSpots)
                    {
                        listBox.Items.Add(ps.TicketNo + "\t" + ps.TimeIn);
                    }
                }
            }
            else
            {
                MessageBox.Show("I'm sorry, this garage is full. \n Please try again later.");
            }
            
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //show the box where user can enter data
            gbExit.Visible = true;
            //hide all the other boxes
        }

        private void bttnGenerateTicket_Click(object sender, EventArgs e)
        {
            double hours;

            int userTicket = Convert.ToInt32(txtTicketNo.Text);

            foreach (Ticket arch in ticketArchive)
            {
                if (userTicket == arch.TicketNo)
                {
                    MessageBox.Show("This Ticket has already been printed.\n\nPlease enter a different ticket number.");
                }
            }



            //This is the part that prints the info.  Be sure to use the include statement at the top so that you can use linq statements. 
            foreach (Ticket tkt in parkingSpots) //creating foreach loop to look through each ticket in the list, match it, and display it to the correct output box. 
            {
                if(userTicket==tkt.TicketNo)
                {
                    try
                    {
                        tkt.TimeOut = Convert.ToDateTime(txtExitTime.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Time.");
                        break;
                    }

                    if (tkt.TimeIn>tkt.TimeOut)
                    {
                        MessageBox.Show("Please enter a future time.");
                        break;
                    }
                    
                    //calculate the difference between times
                    hours = (tkt.TimeOut.Subtract(tkt.TimeIn).TotalHours);
                    //calculate fee and display to user
                    decimal cost = Ticket.CalculateCharge(hours);
                    MessageBox.Show("Your total is: $" + cost + "\n\nPlease see the attendant for payment. \n\nThank you for using the Parking System!\n\n Have a great day!");

                    //hide data box, and show the other options again. 
                    gbExit.Visible = false;
                    txtExitTime.Clear();
                    txtTicketNo.Clear();
                    availableSpots++;

                    //add newly created ticket to output box - This is a ticket that has been paid now.  it goes to teh archive
                    OutputBox.Items.Add(tkt.TicketNo +"\t"+tkt.TimeIn+"\t"+tkt.TimeOut);  //object tkt was created in the foreach statement that this is contained in.
                  
                    //There are two groups of tickets.  One for paid - one for not paid yet. 
                    //Add this ticket to archive-paid tickets
                    ticketArchive.Add(tkt);
                    //remove this ticket from unpaid tickets.
                    parkingSpots.Remove(tkt);

                    //refresh active tickets so that the information is updated. 
                    listBox.Items.Clear();
                    foreach (Ticket ps in parkingSpots) //use for each to display into the listbox
                    {
                        listBox.Items.Add(ps.TicketNo + "\t" + ps.TimeIn);
                    }

                    break;
                }   
            }        
        }


        //This portion saves the file to XML
        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //This top part adds the first list to the xml
                var xEle = new XElement("PaidTickets",
                     from tkt in ticketArchive
                     select new XElement("Ticket",
                                  new XAttribute("TicketNum", tkt.TicketNo),
                                    new XElement("TimeIn", tkt.TimeIn),
                                    new XElement("TimeOut", tkt.TimeOut)
                                ));
                //this part adds the second list to the xml
                xEle.Add(new XElement("ActiveTickets",
                     from tkt in parkingSpots
                     select new XElement("Ticket",
                                  new XAttribute("TicketNum", tkt.TicketNo),
                                    new XElement("TimeIn", tkt.TimeIn)                                    
                                )));

                //open dialog to see where user wants to save file
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Filter = "XML File (*.xml)|*.xml";
                DialogResult result = saveDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //if they click ok, then save the xml that we created above to the 
                    //destination they chose. 
                    xEle.Save(saveDlg.FileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            //hide data box, and show the other options again. 
            gbExit.Visible = false;
            txtExitTime.Clear();
            txtTicketNo.Clear();
        }


    }//end parking system
}//end namespace
