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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingSystem));
            this.bttnEnter = new System.Windows.Forms.Button();
            this.bttnGenerateTicket = new System.Windows.Forms.Button();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.txtExitTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbExit = new System.Windows.Forms.GroupBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.gbExit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnEnter
            // 
            this.bttnEnter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnEnter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bttnEnter.FlatAppearance.BorderSize = 3;
            this.bttnEnter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bttnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEnter.Location = new System.Drawing.Point(22, 139);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(251, 161);
            this.bttnEnter.TabIndex = 0;
            this.bttnEnter.Text = "Enter Garage";
            this.bttnEnter.UseVisualStyleBackColor = false;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            // 
            // bttnGenerateTicket
            // 
            this.bttnGenerateTicket.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnGenerateTicket.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bttnGenerateTicket.FlatAppearance.BorderSize = 3;
            this.bttnGenerateTicket.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnGenerateTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bttnGenerateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerateTicket.Location = new System.Drawing.Point(121, 138);
            this.bttnGenerateTicket.Name = "bttnGenerateTicket";
            this.bttnGenerateTicket.Size = new System.Drawing.Size(156, 77);
            this.bttnGenerateTicket.TabIndex = 1;
            this.bttnGenerateTicket.Text = "Generate Ticket";
            this.bttnGenerateTicket.UseVisualStyleBackColor = false;
            this.bttnGenerateTicket.Click += new System.EventHandler(this.bttnGenerateTicket_Click);
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Location = new System.Drawing.Point(177, 52);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(100, 21);
            this.txtTicketNo.TabIndex = 2;
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(177, 91);
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(100, 21);
            this.txtExitTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exit Time (24hr HH:mm): \r\n";
            // 
            // gbExit
            // 
            this.gbExit.Controls.Add(this.bttnCancel);
            this.gbExit.Controls.Add(this.bttnGenerateTicket);
            this.gbExit.Controls.Add(this.label2);
            this.gbExit.Controls.Add(this.txtTicketNo);
            this.gbExit.Controls.Add(this.label1);
            this.gbExit.Controls.Add(this.txtExitTime);
            this.gbExit.Location = new System.Drawing.Point(97, 88);
            this.gbExit.Name = "gbExit";
            this.gbExit.Size = new System.Drawing.Size(381, 247);
            this.gbExit.TabIndex = 6;
            this.gbExit.TabStop = false;
            this.gbExit.Text = "Exit Garage";
            this.gbExit.Visible = false;
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bttnCancel.FlatAppearance.BorderSize = 3;
            this.bttnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.Location = new System.Drawing.Point(310, 19);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(59, 31);
            this.bttnCancel.TabIndex = 6;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bttnExit.FlatAppearance.BorderSize = 3;
            this.bttnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Location = new System.Drawing.Point(317, 139);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(251, 161);
            this.bttnExit.TabIndex = 7;
            this.bttnExit.Text = "Exit Garage";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 57);
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
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.gbExit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bttnEnter);
            this.tabPage1.Controls.Add(this.bttnExit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Actions";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.bttnSave);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 202);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paid Tickets";
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.Location = new System.Drawing.Point(23, 20);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(414, 173);
            this.OutputBox.TabIndex = 1;
            // 
            // bttnSave
            // 
            this.bttnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.bttnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bttnSave.FlatAppearance.BorderSize = 3;
            this.bttnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Location = new System.Drawing.Point(480, 40);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(115, 61);
            this.bttnSave.TabIndex = 0;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = false;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active Tickets";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(23, 20);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(414, 147);
            this.listBox.TabIndex = 2;
            // 
            // ParkingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(613, 435);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParkingSystem";
            this.Text = "Parking System";
            this.gbExit.ResumeLayout(false);
            this.gbExit.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox;
    }
}

