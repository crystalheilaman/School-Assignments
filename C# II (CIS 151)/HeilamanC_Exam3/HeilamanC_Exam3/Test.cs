using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeilamanC_Exam3
{
    class Test
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderForm());
        }
      


        //static void Main(string[] args)
        //{
        //    //create objects
        //    Dishwashers dw = new Dishwashers(false);
        //    Dishwashers dwInstall = new Dishwashers(true);
        //    Refrigerators rf = new Refrigerators(false);
        //    Refrigerators rfInstall = new Refrigerators(true);
        //    Stoves st = new Stoves(false);
        //    Stoves stInstall = new Stoves(true);
        //    Chairs ch = new Chairs(false);
        //    Chairs chInstall = new Chairs(true);
        //    Sofas sf = new Sofas(false);
        //    Sofas sfInstall = new Sofas(true);


        //    //This test application will be in console and should create one instance 
        //    //of each class with and without installation and print the object information to the screen. 
        //    Console.WriteLine("Welcome to The Furniture Store!\n");

        //    dw.ToString();
        //    dwInstall.ToString();
        //    Console.WriteLine("\n");
        //    rf.ToString(); 
        //    rfInstall.ToString();
        //    Console.WriteLine("\n");
        //    st.ToString();
        //    stInstall.ToString();
        //    Console.WriteLine("\n");
        //    ch.ToString();
        //    chInstall.ToString();
        //    Console.WriteLine("\n");
        //    sf.ToString();
        //    sfInstall.ToString();
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Thank you!");    

        //    //pause program
        //    Console.ReadKey();
        //}//end Main
    }//end class program
}//end namespace
