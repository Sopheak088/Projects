namespace Notice.Report.View
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblSavingOut = new System.Windows.Forms.Label();
            this.pBankSavingAccount = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblSavingIn = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblOwnCashOut = new System.Windows.Forms.Label();
            this.lblOwnCahIin = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pBankOwnAccount = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pPayment = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pBalance = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 31);
            this.panel1.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.ErrorImage = null;
            this.btnBack.Image = global::Notice.Properties.Resources.previous_25px;
            this.btnBack.ImageActive = null;
            this.btnBack.InitialImage = null;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 26);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 7;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 15;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiGroupBox4);
            this.panel2.Controls.Add(this.uiGroupBox3);
            this.panel2.Controls.Add(this.uiGroupBox2);
            this.panel2.Controls.Add(this.uiGroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 544);
            this.panel2.TabIndex = 10;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.lblSavingOut);
            this.uiGroupBox4.Controls.Add(this.pBankSavingAccount);
            this.uiGroupBox4.Controls.Add(this.lblSavingIn);
            this.uiGroupBox4.Controls.Add(this.label16);
            this.uiGroupBox4.Controls.Add(this.label15);
            this.uiGroupBox4.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.uiGroupBox4.Location = new System.Drawing.Point(12, 406);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(292, 126);
            this.uiGroupBox4.TabIndex = 8;
            this.uiGroupBox4.Text = "Bank Saving Account";
            // 
            // lblSavingOut
            // 
            this.lblSavingOut.AutoSize = true;
            this.lblSavingOut.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblSavingOut.Location = new System.Drawing.Point(197, 70);
            this.lblSavingOut.Name = "lblSavingOut";
            this.lblSavingOut.Size = new System.Drawing.Size(14, 21);
            this.lblSavingOut.TabIndex = 8;
            this.lblSavingOut.Text = ".";
            // 
            // pBankSavingAccount
            // 
            this.pBankSavingAccount.animated = false;
            this.pBankSavingAccount.animationIterval = 5;
            this.pBankSavingAccount.animationSpeed = 300;
            this.pBankSavingAccount.BackColor = System.Drawing.Color.Transparent;
            this.pBankSavingAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBankSavingAccount.BackgroundImage")));
            this.pBankSavingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.pBankSavingAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.pBankSavingAccount.LabelVisible = true;
            this.pBankSavingAccount.LineProgressThickness = 8;
            this.pBankSavingAccount.LineThickness = 5;
            this.pBankSavingAccount.Location = new System.Drawing.Point(6, 15);
            this.pBankSavingAccount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pBankSavingAccount.MaxValue = 100;
            this.pBankSavingAccount.Name = "pBankSavingAccount";
            this.pBankSavingAccount.ProgressBackColor = System.Drawing.Color.DimGray;
            this.pBankSavingAccount.ProgressColor = System.Drawing.Color.Navy;
            this.pBankSavingAccount.Size = new System.Drawing.Size(107, 107);
            this.pBankSavingAccount.TabIndex = 0;
            this.pBankSavingAccount.Value = 0;
            // 
            // lblSavingIn
            // 
            this.lblSavingIn.AutoSize = true;
            this.lblSavingIn.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblSavingIn.Location = new System.Drawing.Point(195, 43);
            this.lblSavingIn.Name = "lblSavingIn";
            this.lblSavingIn.Size = new System.Drawing.Size(14, 21);
            this.lblSavingIn.TabIndex = 7;
            this.lblSavingIn.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label16.Location = new System.Drawing.Point(127, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Cash In";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label15.Location = new System.Drawing.Point(127, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "Cash Out";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.lblOwnCashOut);
            this.uiGroupBox3.Controls.Add(this.lblOwnCahIin);
            this.uiGroupBox3.Controls.Add(this.label13);
            this.uiGroupBox3.Controls.Add(this.label14);
            this.uiGroupBox3.Controls.Add(this.pBankOwnAccount);
            this.uiGroupBox3.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.uiGroupBox3.Location = new System.Drawing.Point(12, 270);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(292, 126);
            this.uiGroupBox3.TabIndex = 7;
            this.uiGroupBox3.Text = "Bank Own Account";
            // 
            // lblOwnCashOut
            // 
            this.lblOwnCashOut.AutoSize = true;
            this.lblOwnCashOut.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblOwnCashOut.Location = new System.Drawing.Point(188, 70);
            this.lblOwnCashOut.Name = "lblOwnCashOut";
            this.lblOwnCashOut.Size = new System.Drawing.Size(14, 21);
            this.lblOwnCashOut.TabIndex = 4;
            this.lblOwnCashOut.Text = ".";
            // 
            // lblOwnCahIin
            // 
            this.lblOwnCahIin.AutoSize = true;
            this.lblOwnCahIin.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblOwnCahIin.Location = new System.Drawing.Point(186, 43);
            this.lblOwnCahIin.Name = "lblOwnCahIin";
            this.lblOwnCahIin.Size = new System.Drawing.Size(14, 21);
            this.lblOwnCahIin.TabIndex = 3;
            this.lblOwnCahIin.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label13.Location = new System.Drawing.Point(118, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cash Out";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label14.Location = new System.Drawing.Point(118, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Cash In";
            // 
            // pBankOwnAccount
            // 
            this.pBankOwnAccount.animated = false;
            this.pBankOwnAccount.animationIterval = 5;
            this.pBankOwnAccount.animationSpeed = 300;
            this.pBankOwnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pBankOwnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBankOwnAccount.BackgroundImage")));
            this.pBankOwnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.pBankOwnAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.pBankOwnAccount.LabelVisible = true;
            this.pBankOwnAccount.LineProgressThickness = 8;
            this.pBankOwnAccount.LineThickness = 5;
            this.pBankOwnAccount.Location = new System.Drawing.Point(6, 15);
            this.pBankOwnAccount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pBankOwnAccount.MaxValue = 100;
            this.pBankOwnAccount.Name = "pBankOwnAccount";
            this.pBankOwnAccount.ProgressBackColor = System.Drawing.Color.DimGray;
            this.pBankOwnAccount.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pBankOwnAccount.Size = new System.Drawing.Size(101, 101);
            this.pBankOwnAccount.TabIndex = 0;
            this.pBankOwnAccount.Value = 0;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.lblPaid);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.pPayment);
            this.uiGroupBox2.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.uiGroupBox2.Location = new System.Drawing.Point(12, 138);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(292, 126);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = "Payment";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblPaid.Location = new System.Drawing.Point(188, 53);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(14, 21);
            this.lblPaid.TabIndex = 6;
            this.lblPaid.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label3.Location = new System.Drawing.Point(118, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment";
            // 
            // pPayment
            // 
            this.pPayment.animated = false;
            this.pPayment.animationIterval = 5;
            this.pPayment.animationSpeed = 300;
            this.pPayment.BackColor = System.Drawing.Color.Transparent;
            this.pPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPayment.BackgroundImage")));
            this.pPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.pPayment.ForeColor = System.Drawing.Color.SeaGreen;
            this.pPayment.LabelVisible = true;
            this.pPayment.LineProgressThickness = 8;
            this.pPayment.LineThickness = 5;
            this.pPayment.Location = new System.Drawing.Point(6, 15);
            this.pPayment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pPayment.MaxValue = 100;
            this.pPayment.Name = "pPayment";
            this.pPayment.ProgressBackColor = System.Drawing.Color.DimGray;
            this.pPayment.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pPayment.Size = new System.Drawing.Size(101, 101);
            this.pPayment.TabIndex = 0;
            this.pPayment.Value = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.lblPayment);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.lblIncome);
            this.uiGroupBox1.Controls.Add(this.lblBalance);
            this.uiGroupBox1.Controls.Add(this.label22);
            this.uiGroupBox1.Controls.Add(this.label11);
            this.uiGroupBox1.Controls.Add(this.pBalance);
            this.uiGroupBox1.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 6);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(292, 126);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Balance";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblPayment.Location = new System.Drawing.Point(188, 88);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(14, 21);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label2.Location = new System.Drawing.Point(118, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payment";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblIncome.Location = new System.Drawing.Point(188, 60);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(14, 21);
            this.lblIncome.TabIndex = 4;
            this.lblIncome.Text = ".";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.lblBalance.Location = new System.Drawing.Point(186, 33);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(14, 21);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = ".";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label22.Location = new System.Drawing.Point(118, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 21);
            this.label22.TabIndex = 2;
            this.label22.Text = "Income";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hanuman", 10.25F);
            this.label11.Location = new System.Drawing.Point(118, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Balance";
            // 
            // pBalance
            // 
            this.pBalance.animated = false;
            this.pBalance.animationIterval = 5;
            this.pBalance.animationSpeed = 300;
            this.pBalance.BackColor = System.Drawing.Color.Transparent;
            this.pBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBalance.BackgroundImage")));
            this.pBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.pBalance.ForeColor = System.Drawing.Color.SeaGreen;
            this.pBalance.LabelVisible = true;
            this.pBalance.LineProgressThickness = 8;
            this.pBalance.LineThickness = 5;
            this.pBalance.Location = new System.Drawing.Point(6, 15);
            this.pBalance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pBalance.MaxValue = 100;
            this.pBalance.Name = "pBalance";
            this.pBalance.ProgressBackColor = System.Drawing.Color.DimGray;
            this.pBalance.ProgressColor = System.Drawing.Color.SeaGreen;
            this.pBalance.Size = new System.Drawing.Size(101, 101);
            this.pBalance.TabIndex = 0;
            this.pBalance.Value = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 575);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hanuman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pBalance;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pBankSavingAccount;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private System.Windows.Forms.Label lblOwnCashOut;
        private System.Windows.Forms.Label lblOwnCahIin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pBankOwnAccount;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pPayment;
        private System.Windows.Forms.Label lblSavingOut;
        private System.Windows.Forms.Label lblSavingIn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}