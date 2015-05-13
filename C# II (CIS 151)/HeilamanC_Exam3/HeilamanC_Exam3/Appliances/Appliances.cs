using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilamanC_Exam3
{
    abstract class Appliances
    {
       
        
        
        //Each base object should have a Calculate method and ToString method that are overridden 
        //in the derived classes.  
        virtual public string ToString() { return ""; }//end ToString
        virtual public int Calculate() { return 0; }//end Calculate

    }//end class Appliances
}//end namespace
