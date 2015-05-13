using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeilamanC_Exam3
{
    public partial class OrderForm : Form
    {

        //create objects
        Dishwashers dw = new Dishwashers(false);
        Dishwashers dwInstall = new Dishwashers(true);
        Refrigerators rf = new Refrigerators(false);
        Refrigerators rfInstall = new Refrigerators(true);
        Stoves st = new Stoves(false);
        Stoves stInstall = new Stoves(true);
        Chairs ch = new Chairs(false);
        Chairs chInstall = new Chairs(true);
        Sofas sf = new Sofas(false);
        Sofas sfInstall = new Sofas(true);

        List<string> Invoice = new List<string>();        

        public OrderForm()
        {
            InitializeComponent();
        }
        
        //method to calculate monthly pmt
        public decimal CalculatePayment(decimal totalAmount, decimal months)
        {
            return totalAmount / months;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
                       
        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtName.Text == "")
            {
                lblInvalidName.Visible = true;
            }

            if (txtMonths.Text == "")
            {
                lblInvalidMonths.Visible = true;
            }

            if (!txtPhone.MaskCompleted)
            {
                lblInvalidPhone.Visible = true;
            }


            if (!lblInvalidPhone.Visible && !lblInvalidName.Visible && !lblInvalidMonths.Visible)
            {
                int amount;
                decimal totalAmount = 0;

                //add formatting to Invoice
                Invoice.Add("INVOICE");
                Invoice.Add("===============================================");
                Invoice.Add("");

                //get company information and add to invoice list
                Invoice.Add("Company Name: " + txtName.Text);
                Invoice.Add("Company Phone: " + txtPhone.Text);
                Invoice.Add("");
                Invoice.Add("===============================================");
                Invoice.Add("");



                // Evaluate input
                if (txtStove.Text != "")
                {
                    amount = Convert.ToInt16(txtStove.Text);

                    for (int i = 0; i < amount; i++)
                    {
                        //determine if it is installed/not installed. 
                        if (chkStove.Checked)
                        {
                            Invoice.Add(stInstall.ToString());
                            //calculate cost of object that is selected. 
                            totalAmount += stInstall.Calculate();
                            Invoice.Add("");
                        }
                        else
                        {
                            Invoice.Add(st.ToString());
                            //calculate cost of object that is selected.
                            totalAmount += st.Calculate();
                            Invoice.Add("");
                        }
                    }//end for                
                }//end if


                if (txtRefrigerator.Text != "")
                {
                    amount = Convert.ToInt16(txtRefrigerator.Text);

                    for (int i = 0; i < amount; i++)
                    {
                        //determine if it is installed/not installed. 
                        if (chkRefrigerator.Checked)
                        {
                            Invoice.Add(rfInstall.ToString());
                            //calculate cost of object that is selected. 
                            totalAmount += rfInstall.Calculate();
                            Invoice.Add("");
                        }
                        else
                        {
                            Invoice.Add(rf.ToString());
                            //calculate cost of object that is selected.
                            totalAmount += rf.Calculate();
                            Invoice.Add("");
                        }
                    }//end for 
                }


                if (txtDishwasher.Text != "")
                {
                    amount = Convert.ToInt16(txtDishwasher.Text);

                    for (int i = 0; i < amount; i++)
                    {
                        //determine if it is installed/not installed. 
                        if (chkDishwasher.Checked)
                        {
                            Invoice.Add(dwInstall.ToString());
                            //calculate cost of object that is selected. 
                            totalAmount += dwInstall.Calculate();
                            Invoice.Add("");
                        }
                        else
                        {
                            Invoice.Add(dw.ToString());
                            //calculate cost of object that is selected.
                            totalAmount += dw.Calculate();
                            Invoice.Add("");
                        }
                    }//end for 
                }



                if (txtChair.Text != "")
                {
                    amount = Convert.ToInt16(txtChair.Text);

                    for (int i = 0; i < amount; i++)
                    {
                        //determine if it is installed/not installed. 
                        if (chkChair.Checked)
                        {
                            Invoice.Add(chInstall.ToString());
                            //calculate cost of object that is selected. 
                            totalAmount += chInstall.Calculate();
                            Invoice.Add("");
                        }
                        else
                        {
                            Invoice.Add(ch.ToString());
                            //calculate cost of object that is selected.
                            totalAmount += ch.Calculate();
                            Invoice.Add("");
                        }
                    }//end for 
                }


                if (txtSofa.Text != "")
                {
                    amount = Convert.ToInt16(txtSofa.Text);

                    for (int i = 0; i < amount; i++)
                    {
                        //determine if it is installed/not installed. 
                        if (chkSofa.Checked)
                        {
                            Invoice.Add(sfInstall.ToString());
                            //calculate cost of object that is selected. 
                            totalAmount += sfInstall.Calculate();
                            Invoice.Add("");
                        }
                        else
                        {
                            Invoice.Add(sf.ToString());
                            //calculate cost of object that is selected.
                            totalAmount += sf.Calculate();
                            Invoice.Add("");
                        }
                    }//end for 
                }

                decimal monthlyPayment = CalculatePayment(totalAmount, Convert.ToDecimal(txtMonths.Text));

                Invoice.Add("");
                Invoice.Add("===============================================");
                Invoice.Add("");
                Invoice.Add("Total Cost: $" + Convert.ToString(totalAmount));
                Invoice.Add("");
                Invoice.Add("MonthlyPayment (" + txtMonths.Text + " months): $" + (monthlyPayment).ToString("#.##"));

                //add info to list box
                foreach (var x in Invoice)
                {
                    lbInvoice.Items.Add(x);
                }
            }
            
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            //clears form
            txtMonths.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtChair.Text = "0";
            txtDishwasher.Text = "0";
            txtRefrigerator.Text = "0";
            txtSofa.Text = "0";
            txtStove.Text = "0";
            chkStove.Checked = false;
            chkDishwasher.Checked = false;
            chkChair.Checked = false;
            chkRefrigerator.Checked = false;
            chkSofa.Checked = false;
            chkStove.Enabled = false;
            chkDishwasher.Enabled = false;
            chkChair.Enabled = false;
            chkRefrigerator.Enabled = false;
            chkSofa.Enabled = false;
            lblInvalidName.Visible = false;
            lblInvalidPhone.Visible = false;
            lblInvalidMonths.Visible = false;

            //clears invoice list
            Invoice.Clear();

            //clears Invoice box
            lbInvoice.Items.Clear();

            txtName.Focus();

        }

        private void txtStove_TextChanged(object sender, EventArgs e)
        {
            chkStove.Enabled = true;
        }

        private void txtRefrigerator_TextChanged(object sender, EventArgs e)
        {
            chkRefrigerator.Enabled = true;
        }

        private void txtDishwasher_TextChanged(object sender, EventArgs e)
        {
            chkDishwasher.Enabled = true;
        }

        private void txtChair_TextChanged(object sender, EventArgs e)
        {
            chkChair.Enabled = true;
        }

        private void txtSofa_TextChanged(object sender, EventArgs e)
        {
            chkSofa.Enabled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (lblInvalidName.Visible)
            {
                lblInvalidName.Visible = false;
            }
        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                lblInvalidPhone.Visible = true;            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (lblInvalidPhone.Visible)
            {
                lblInvalidPhone.Visible = false;
            }
        }


    }
}
