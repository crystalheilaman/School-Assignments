namespace HeilamanC_Exam3
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnCalculate = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lbInvoice = new System.Windows.Forms.ListBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbMonths = new System.Windows.Forms.GroupBox();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.txtStove = new System.Windows.Forms.TextBox();
            this.txtRefrigerator = new System.Windows.Forms.TextBox();
            this.txtDishwasher = new System.Windows.Forms.TextBox();
            this.txtChair = new System.Windows.Forms.TextBox();
            this.txtSofa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRefrigerator = new System.Windows.Forms.CheckBox();
            this.chkDishwasher = new System.Windows.Forms.CheckBox();
            this.chkChair = new System.Windows.Forms.CheckBox();
            this.chkSofa = new System.Windows.Forms.CheckBox();
            this.chkStove = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblInvalidName = new System.Windows.Forms.Label();
            this.lblInvalidPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblInvalidMonths = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.gbMonths.SuspendLayout();
            this.gbInvoice.SuspendLayout();
            this.gbProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnCalculate
            // 
            this.bttnCalculate.Location = new System.Drawing.Point(180, 396);
            this.bttnCalculate.Name = "bttnCalculate";
            this.bttnCalculate.Size = new System.Drawing.Size(139, 77);
            this.bttnCalculate.TabIndex = 14;
            this.bttnCalculate.Text = "Calculate";
            this.bttnCalculate.UseVisualStyleBackColor = true;
            this.bttnCalculate.Click += new System.EventHandler(this.bttnCalculate_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(589, 489);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 15;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(670, 489);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 16;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Company Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 73);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Company Phone:";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(85, 28);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(48, 20);
            this.txtMonths.TabIndex = 13;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(6, 31);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(81, 13);
            this.lblMonths.TabIndex = 10;
            this.lblMonths.Text = "Months to Pay: ";
            // 
            // lbInvoice
            // 
            this.lbInvoice.FormattingEnabled = true;
            this.lbInvoice.Location = new System.Drawing.Point(6, 19);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(381, 420);
            this.lbInvoice.TabIndex = 0;
            this.lbInvoice.TabStop = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.lblInvalidPhone);
            this.gbInfo.Controls.Add(this.lblInvalidName);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.lblPhone);
            this.gbInfo.Location = new System.Drawing.Point(24, 30);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(295, 125);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Company Information";
            // 
            // gbMonths
            // 
            this.gbMonths.Controls.Add(this.lblInvalidMonths);
            this.gbMonths.Controls.Add(this.txtMonths);
            this.gbMonths.Controls.Add(this.lblMonths);
            this.gbMonths.Location = new System.Drawing.Point(24, 396);
            this.gbMonths.Name = "gbMonths";
            this.gbMonths.Size = new System.Drawing.Size(139, 77);
            this.gbMonths.TabIndex = 3;
            this.gbMonths.TabStop = false;
            this.gbMonths.Text = "Payment Terms";
            // 
            // gbInvoice
            // 
            this.gbInvoice.Controls.Add(this.lbInvoice);
            this.gbInvoice.Location = new System.Drawing.Point(352, 30);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Size = new System.Drawing.Size(393, 443);
            this.gbInvoice.TabIndex = 0;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "# of Item: ";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.label1);
            this.gbProducts.Controls.Add(this.txtStove);
            this.gbProducts.Controls.Add(this.txtRefrigerator);
            this.gbProducts.Controls.Add(this.txtDishwasher);
            this.gbProducts.Controls.Add(this.txtChair);
            this.gbProducts.Controls.Add(this.txtSofa);
            this.gbProducts.Controls.Add(this.label2);
            this.gbProducts.Controls.Add(this.chkRefrigerator);
            this.gbProducts.Controls.Add(this.chkDishwasher);
            this.gbProducts.Controls.Add(this.chkChair);
            this.gbProducts.Controls.Add(this.chkSofa);
            this.gbProducts.Controls.Add(this.chkStove);
            this.gbProducts.Controls.Add(this.label6);
            this.gbProducts.Controls.Add(this.label5);
            this.gbProducts.Controls.Add(this.label4);
            this.gbProducts.Controls.Add(this.label3);
            this.gbProducts.Controls.Add(this.lblItem1);
            this.gbProducts.Location = new System.Drawing.Point(24, 161);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(295, 228);
            this.gbProducts.TabIndex = 2;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products";
            // 
            // txtStove
            // 
            this.txtStove.Location = new System.Drawing.Point(130, 42);
            this.txtStove.Name = "txtStove";
            this.txtStove.Size = new System.Drawing.Size(31, 20);
            this.txtStove.TabIndex = 3;
            this.txtStove.Text = "0";
            this.txtStove.TextChanged += new System.EventHandler(this.txtStove_TextChanged);
            // 
            // txtRefrigerator
            // 
            this.txtRefrigerator.Location = new System.Drawing.Point(130, 77);
            this.txtRefrigerator.Name = "txtRefrigerator";
            this.txtRefrigerator.Size = new System.Drawing.Size(31, 20);
            this.txtRefrigerator.TabIndex = 5;
            this.txtRefrigerator.Text = "0";
            this.txtRefrigerator.TextChanged += new System.EventHandler(this.txtRefrigerator_TextChanged);
            // 
            // txtDishwasher
            // 
            this.txtDishwasher.Location = new System.Drawing.Point(130, 113);
            this.txtDishwasher.Name = "txtDishwasher";
            this.txtDishwasher.Size = new System.Drawing.Size(31, 20);
            this.txtDishwasher.TabIndex = 7;
            this.txtDishwasher.Text = "0";
            this.txtDishwasher.TextChanged += new System.EventHandler(this.txtDishwasher_TextChanged);
            // 
            // txtChair
            // 
            this.txtChair.Location = new System.Drawing.Point(130, 149);
            this.txtChair.Name = "txtChair";
            this.txtChair.Size = new System.Drawing.Size(31, 20);
            this.txtChair.TabIndex = 9;
            this.txtChair.Text = "0";
            this.txtChair.TextChanged += new System.EventHandler(this.txtChair_TextChanged);
            // 
            // txtSofa
            // 
            this.txtSofa.Location = new System.Drawing.Point(130, 185);
            this.txtSofa.Name = "txtSofa";
            this.txtSofa.Size = new System.Drawing.Size(31, 20);
            this.txtSofa.TabIndex = 11;
            this.txtSofa.Text = "0";
            this.txtSofa.TextChanged += new System.EventHandler(this.txtSofa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Installation Required?";
            // 
            // chkRefrigerator
            // 
            this.chkRefrigerator.AutoSize = true;
            this.chkRefrigerator.Enabled = false;
            this.chkRefrigerator.Location = new System.Drawing.Point(202, 79);
            this.chkRefrigerator.Name = "chkRefrigerator";
            this.chkRefrigerator.Size = new System.Drawing.Size(53, 17);
            this.chkRefrigerator.TabIndex = 6;
            this.chkRefrigerator.Text = "+ $50";
            this.chkRefrigerator.UseVisualStyleBackColor = true;
            // 
            // chkDishwasher
            // 
            this.chkDishwasher.AutoSize = true;
            this.chkDishwasher.Enabled = false;
            this.chkDishwasher.Location = new System.Drawing.Point(202, 115);
            this.chkDishwasher.Name = "chkDishwasher";
            this.chkDishwasher.Size = new System.Drawing.Size(59, 17);
            this.chkDishwasher.TabIndex = 8;
            this.chkDishwasher.Text = "+ $100";
            this.chkDishwasher.UseVisualStyleBackColor = true;
            // 
            // chkChair
            // 
            this.chkChair.AutoSize = true;
            this.chkChair.Enabled = false;
            this.chkChair.Location = new System.Drawing.Point(202, 151);
            this.chkChair.Name = "chkChair";
            this.chkChair.Size = new System.Drawing.Size(47, 17);
            this.chkChair.TabIndex = 10;
            this.chkChair.Text = "Free";
            this.chkChair.UseVisualStyleBackColor = true;
            // 
            // chkSofa
            // 
            this.chkSofa.AutoSize = true;
            this.chkSofa.Enabled = false;
            this.chkSofa.Location = new System.Drawing.Point(202, 187);
            this.chkSofa.Name = "chkSofa";
            this.chkSofa.Size = new System.Drawing.Size(47, 17);
            this.chkSofa.TabIndex = 12;
            this.chkSofa.Text = "Free";
            this.chkSofa.UseVisualStyleBackColor = true;
            // 
            // chkStove
            // 
            this.chkStove.AutoSize = true;
            this.chkStove.Enabled = false;
            this.chkStove.Location = new System.Drawing.Point(202, 44);
            this.chkStove.Name = "chkStove";
            this.chkStove.Size = new System.Drawing.Size(53, 17);
            this.chkStove.TabIndex = 4;
            this.chkStove.Text = "+ $75";
            this.chkStove.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "[5] Sofa - $500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "[4] Chair - $250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "[3] Dishwasher - $75";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "[2] Refrigerator - $250";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Location = new System.Drawing.Point(34, 46);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(83, 13);
            this.lblItem1.TabIndex = 0;
            this.lblItem1.Text = "[1] Stove - $200";
            // 
            // lblInvalidName
            // 
            this.lblInvalidName.AutoSize = true;
            this.lblInvalidName.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidName.Location = new System.Drawing.Point(95, 48);
            this.lblInvalidName.Name = "lblInvalidName";
            this.lblInvalidName.Size = new System.Drawing.Size(149, 13);
            this.lblInvalidName.TabIndex = 7;
            this.lblInvalidName.Text = "*Please Enter Company Name";
            this.lblInvalidName.Visible = false;
            // 
            // lblInvalidPhone
            // 
            this.lblInvalidPhone.AutoSize = true;
            this.lblInvalidPhone.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPhone.Location = new System.Drawing.Point(94, 93);
            this.lblInvalidPhone.Name = "lblInvalidPhone";
            this.lblInvalidPhone.Size = new System.Drawing.Size(116, 13);
            this.lblInvalidPhone.TabIndex = 8;
            this.lblInvalidPhone.Text = "*Invalid Phone Number";
            this.lblInvalidPhone.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtPhone.Location = new System.Drawing.Point(97, 69);
            this.txtPhone.Mask = "(999)-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(189, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhone_MaskInputRejected);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblInvalidMonths
            // 
            this.lblInvalidMonths.AutoSize = true;
            this.lblInvalidMonths.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidMonths.Location = new System.Drawing.Point(6, 54);
            this.lblInvalidMonths.Name = "lblInvalidMonths";
            this.lblInvalidMonths.Size = new System.Drawing.Size(119, 13);
            this.lblInvalidMonths.TabIndex = 14;
            this.lblInvalidMonths.Text = "*Please Enter # Months";
            this.lblInvalidMonths.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 530);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbInvoice);
            this.Controls.Add(this.gbMonths);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMonths.ResumeLayout(false);
            this.gbMonths.PerformLayout();
            this.gbInvoice.ResumeLayout(false);
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnCalculate;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.ListBox lbInvoice;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbMonths;
        private System.Windows.Forms.GroupBox gbInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRefrigerator;
        private System.Windows.Forms.CheckBox chkDishwasher;
        private System.Windows.Forms.CheckBox chkChair;
        private System.Windows.Forms.CheckBox chkSofa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStove;
        private System.Windows.Forms.TextBox txtRefrigerator;
        private System.Windows.Forms.TextBox txtDishwasher;
        private System.Windows.Forms.TextBox txtChair;
        private System.Windows.Forms.TextBox txtSofa;
        private System.Windows.Forms.CheckBox chkStove;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblInvalidPhone;
        private System.Windows.Forms.Label lblInvalidName;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblInvalidMonths;
    }
}