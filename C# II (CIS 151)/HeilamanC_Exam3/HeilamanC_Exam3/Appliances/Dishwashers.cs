using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilamanC_Exam3
{
    class Dishwashers:Appliances
    {
        //Dishwashers $75.  Installation $100

        public int Cost { get; set; }
        public int Installation { get; set; }
        public bool IsInstalled { get; set; }

        public Dishwashers(bool installed)
        {
            Cost = 75;
            Installation = 100;
            IsInstalled = installed;
        }


        //Each base object should have a Calculate method and ToString method that are overridden 
        //in the derived classes.  

        override public int Calculate()
        {
            //Calculate should be used to figure the cost of the item with or without installation.  
            if (IsInstalled)
            {
                //calculate cost with installation fee
                return (Cost + Installation);
            }
            else
            {
                //calculate cost without installation fee
                return Cost;
            }

        }//end calculate
            
     
        override public string ToString()
        {
            if (IsInstalled)
            {
                //ToString should be used to output the object and price appropriately.
                return "Dishwasher + Installation: $" + Calculate() + "\n";
            }
            else
            {
                //ToString should be used to output the object and price appropriately.
                return "Dishwasher: $" + Calculate() + "\n";
            }


        }//end ToString
    }//end class Dishwashers
}//end namespace
