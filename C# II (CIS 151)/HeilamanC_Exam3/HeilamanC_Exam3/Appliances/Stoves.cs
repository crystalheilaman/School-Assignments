using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilamanC_Exam3
{
    class Stoves : Appliances
    {
        //Stoves $200.  Installation $75

        //properties
        public int Cost { get; set; }
        public int Installation { get; set; }
        public bool IsInstalled { get; set; }
        
        public Stoves(bool installed)
        {
            Cost = 200;
            Installation = 75;
            IsInstalled = installed;
        }

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
            


        //Each base object should have a Calculate method and ToString method that are overridden 
        //in the derived classes.  
        override public string ToString()
        {
            if (IsInstalled)
            {
                //ToString should be used to output the object and price appropriately.
                return "Stove + Installation: $" + Calculate() + "\n";
            }
            else
            {
                //ToString should be used to output the object and price appropriately.
                return "Stove: $" + Calculate() + "\n";
            }


        }//end ToString
    }//end class stoves
}//end namespace
