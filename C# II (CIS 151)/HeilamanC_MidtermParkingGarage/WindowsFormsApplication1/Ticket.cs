using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Ticket
    {
        //properties
        public int TicketNo { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        
        //constructor
        public Ticket(int ticketNo, DateTime timeIn)
        {
            TicketNo = ticketNo;
            TimeIn = timeIn;            
        }//end constructor


        //methods
        public static decimal CalculateCharge()
        {
            //$2 base fee for 3 hours
            //$.50 for each hour after 3 hours
            //Maximum charge is $10.

            //get data from boxes and generate ticket

            

            return 1;
        }

    }//end class ticket
}//end namespace
