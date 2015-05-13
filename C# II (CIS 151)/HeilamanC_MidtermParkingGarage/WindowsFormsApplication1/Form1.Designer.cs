namespace WindowsFormsApplication1
{
    partial class ParkingSystem
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
            this.bttnEnter = new System.Windows.Forms.Button();
            this.bttnGenerateTicket = new System.Windows.Forms.Button();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.txtExitTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbExit = new System.Windows.Forms.GroupBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.gbExit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnEnter
            // 
            this.bttnEnter.Location = new System.Drawing.Point(82, 144);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(251, 161);
            this.bttnEnter.TabIndex = 0;
            this.bttnEnter.Text = "Enter Garage";
            this.bttnEnter.UseVisualStyleBackColor = true;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            // 
            // bttnGenerateTicket
            // 
            this.bttnGenerateTicket.Location = new System.Drawing.Point(154, 115);
            this.bttnGenerateTicket.Name = "bttnGenerateTicket";
            this.bttnGenerateTicket.Size = new System.Drawing.Size(165, 58);
            this.bttnGenerateTicket.TabIndex = 1;
            this.bttnGenerateTicket.Text = "Generate Ticket";
            this.bttnGenerateTicket.UseVisualStyleBackColor = true;
            this.bttnGenerateTicket.Click += new System.EventHandler(this.bttnGenerateTicket_Click);
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Location = new System.Drawing.Point(141, 39);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(100, 20);
            this.txtTicketNo.TabIndex = 2;
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(141, 77);
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(100, 20);
            this.txtExitTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Numer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure Time: ";
            // 
            // gbExit
            // 
            this.gbExit.Controls.Add(this.bttnGenerateTicket);
            this.gbExit.Controls.Add(this.label2);
            this.gbExit.Controls.Add(this.txtTicketNo);
            this.gbExit.Controls.Add(this.label1);
            this.gbExit.Controls.Add(this.txtExitTime);
            this.gbExit.Location = new System.Drawing.Point(432, 370);
            this.gbExit.Name = "gbExit";
            this.gbExit.Size = new System.Drawing.Size(338, 199);
            this.gbExit.TabIndex = 6;
            this.gbExit.TabStop = false;
            this.gbExit.Text = "Exit Garage";
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(391, 144);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(251, 161);
            this.bttnExit.TabIndex = 7;
            this.bttnExit.Text = "Exit Garage";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome to the Garage!\r\n\r\nHow may we help you?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 627);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bttnEnter);
            this.tabPage1.Controls.Add(this.bttnExit);
            this.tabPage1.Controls.Add(this.gbExit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.bttnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutputBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 480);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Issued";
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.Location = new System.Drawing.Point(15, 19);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(400, 446);
            this.OutputBox.TabIndex = 1;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(688, 419);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 0;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            // 
            // ParkingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 628);
            this.Controls.Add(this.tabControl1);
            this.Name = "ParkingSystem";
            this.Text = "Parking System";
            this.gbExit.ResumeLayout(false);
            this.gbExit.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnEnter;
        private System.Windows.Forms.Button bttnGenerateTicket;
        private System.Windows.Forms.TextBox txtTicketNo;
        private System.Windows.Forms.TextBox txtExitTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbExit;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

