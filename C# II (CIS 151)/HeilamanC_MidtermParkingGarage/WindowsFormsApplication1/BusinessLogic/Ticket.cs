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
        public static decimal CalculateCharge(double hours)
        {
            //$2 base fee for 3 hours
            //$.50 for each hour after 3 hours
            //Maximum charge is $10.
            decimal cost = 2.00m;
            
            for (int i = 3; i < hours ; i++)
            {
                cost = cost + 0.5m;
            }

            if (cost > 10)
            {
                cost = 10;
            }
                return cost;
        }
        
    }//end class ticket
}//end namespace
