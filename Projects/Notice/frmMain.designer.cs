namespace Notice
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnNote = new System.Windows.Forms.Label();
            this.btnGallery = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Label();
            this.btnLove = new System.Windows.Forms.Label();
            this.pLoading = new System.Windows.Forms.Panel();
            this.btnBankSaving = new System.Windows.Forms.Label();
            this.roundpLoading = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnYourPayment = new System.Windows.Forms.Label();
            this.btnBank = new System.Windows.Forms.Label();
            this.btnCashIncome = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEvent = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 83;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.Transparent;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Image = global::Notice.Properties.Resources.note_50px;
            this.btnNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNote.Location = new System.Drawing.Point(13, 476);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(70, 63);
            this.btnNote.TabIndex = 0;
            this.btnNote.Text = "Note";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnGallery
            // 
            this.btnGallery.BackColor = System.Drawing.Color.Transparent;
            this.btnGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGallery.Image = global::Notice.Properties.Resources.picture_50px_1;
            this.btnGallery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGallery.Location = new System.Drawing.Point(89, 476);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(70, 63);
            this.btnGallery.TabIndex = 1;
            this.btnGallery.Text = "Gallery";
            this.btnGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Image = global::Notice.Properties.Resources.banknotes_50px;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayment.Location = new System.Drawing.Point(166, 476);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(70, 63);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnLove
            // 
            this.btnLove.BackColor = System.Drawing.Color.Transparent;
            this.btnLove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLove.Image = global::Notice.Properties.Resources.wedding_day_50px_1;
            this.btnLove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLove.Location = new System.Drawing.Point(242, 476);
            this.btnLove.Name = "btnLove";
            this.btnLove.Size = new System.Drawing.Size(70, 63);
            this.btnLove.TabIndex = 3;
            this.btnLove.Text = "Love";
            this.btnLove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLove.Click += new System.EventHandler(this.btnLove_Click);
            // 
            // pLoading
            // 
            this.pLoading.BackColor = System.Drawing.Color.Transparent;
            this.pLoading.Location = new System.Drawing.Point(7, 29);
            this.pLoading.Name = "pLoading";
            this.pLoading.Size = new System.Drawing.Size(316, 18);
            this.pLoading.TabIndex = 4;
            this.pLoading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pLoading_MouseMove);
            // 
            // btnBankSaving
            // 
            this.btnBankSaving.BackColor = System.Drawing.Color.Transparent;
            this.btnBankSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankSaving.Image = global::Notice.Properties.Resources.id_card_50px;
            this.btnBankSaving.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBankSaving.Location = new System.Drawing.Point(17, 245);
            this.btnBankSaving.Name = "btnBankSaving";
            this.btnBankSaving.Size = new System.Drawing.Size(76, 63);
            this.btnBankSaving.TabIndex = 10;
            this.btnBankSaving.Text = "Bank Saving";
            this.btnBankSaving.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBankSaving.Click += new System.EventHandler(this.btnBankSaving_Click);
            // 
            // roundpLoading
            // 
            this.roundpLoading.ElipseRadius = 30;
            this.roundpLoading.TargetControl = this.pLoading;
            // 
            // btnYourPayment
            // 
            this.btnYourPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnYourPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYourPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourPayment.Image = global::Notice.Properties.Resources.bank_50px;
            this.btnYourPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYourPayment.Location = new System.Drawing.Point(16, 318);
            this.btnYourPayment.Name = "btnYourPayment";
            this.btnYourPayment.Size = new System.Drawing.Size(77, 63);
            this.btnYourPayment.TabIndex = 6;
            this.btnYourPayment.Text = "Your Payment";
            this.btnYourPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYourPayment.Click += new System.EventHandler(this.btnYourPayment_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Transparent;
            this.btnBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Image = global::Notice.Properties.Resources.bank_card_back_side_50px;
            this.btnBank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBank.Location = new System.Drawing.Point(13, 402);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(70, 63);
            this.btnBank.TabIndex = 7;
            this.btnBank.Text = "Bank";
            this.btnBank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnCashIncome
            // 
            this.btnCashIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnCashIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashIncome.Image = global::Notice.Properties.Resources.receive_cash_50px;
            this.btnCashIncome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashIncome.Location = new System.Drawing.Point(92, 402);
            this.btnCashIncome.Name = "btnCashIncome";
            this.btnCashIncome.Size = new System.Drawing.Size(76, 63);
            this.btnCashIncome.TabIndex = 8;
            this.btnCashIncome.Text = "Cash Income";
            this.btnCashIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashIncome.Click += new System.EventHandler(this.btnCashIncome_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::Notice.Properties.Resources.report_card_50px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(17, 169);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(76, 63);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Adobe Fangsong Std R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(169, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 23);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = ".";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Image = global::Notice.Properties.Resources.calendar_50px;
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEvent.Location = new System.Drawing.Point(166, 402);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(76, 63);
            this.btnEvent.TabIndex = 12;
            this.btnEvent.Text = "Events";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblEvent.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.Red;
            this.lblEvent.Location = new System.Drawing.Point(16, 42);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(207, 23);
            this.lblEvent.TabIndex = 13;
            this.lblEvent.Text = ".";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::Notice.Properties.Resources.help_50px;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(234, 401);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(76, 63);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notice.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(330, 628);
            this.ControlBox = false;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBankSaving);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCashIncome);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnYourPayment);
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.btnLove);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnGallery);
            this.Controls.Add(this.btnNote);
            this.Font = new System.Drawing.Font("Hanuman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DoubleClick += new System.EventHandler(this.frmMain_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label btnNote;
        private System.Windows.Forms.Label btnLove;
        private System.Windows.Forms.Label btnPayment;
        private System.Windows.Forms.Label btnGallery;
        private Bunifu.Framework.UI.BunifuElipse roundpLoading;
        public System.Windows.Forms.Panel pLoading;
        private System.Windows.Forms.Label btnYourPayment;
        private System.Windows.Forms.Label btnBank;
        private System.Windows.Forms.Label btnCashIncome;
        private System.Windows.Forms.Label btnReport;
        private System.Windows.Forms.Label btnBankSaving;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label btnEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label btnAbout;
    }
}