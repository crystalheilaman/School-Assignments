using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilamanC_Exam3
{
    class Refrigerators:Appliances
    {
        //Refrigerators $250. Installation $50

        public int Cost { get; set; }
        public int Installation { get; set; }
        public bool IsInstalled { get; set; }


        public Refrigerators(bool installed)
        {
            Cost = 250;
            Installation = 50;
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
                return "Refrigerator + Installation: $" + Calculate() + "\n";
            }
            else
            {
                //ToString should be used to output the object and price appropriately.
                return "Refrigerator: $" + Calculate() + "\n";
            }

        }//end ToString
    }//end refrigerators class
}//end namespace
