namespace Notice.LoveCount.View
{
    partial class frmLoveCount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUpdateMaleName = new Bunifu.Framework.UI.BunifuImageButton();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.btnUpdateStartDate = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateFemaleName = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFemale = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtMale = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.picFemale = new System.Windows.Forms.PictureBox();
            this.picMale = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.Man = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Female = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateMaleName)).BeginInit();
            this.pDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateFemaleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMale)).BeginInit();
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
            // btnUpdateMaleName
            // 
            this.btnUpdateMaleName.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMaleName.ErrorImage = null;
            this.btnUpdateMaleName.Image = global::Notice.Properties.Resources.checkmark_25px;
            this.btnUpdateMaleName.ImageActive = null;
            this.btnUpdateMaleName.InitialImage = null;
            this.btnUpdateMaleName.Location = new System.Drawing.Point(122, 316);
            this.btnUpdateMaleName.Name = "btnUpdateMaleName";
            this.btnUpdateMaleName.Size = new System.Drawing.Size(24, 26);
            this.btnUpdateMaleName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdateMaleName.TabIndex = 8;
            this.btnUpdateMaleName.TabStop = false;
            this.btnUpdateMaleName.Zoom = 15;
            this.btnUpdateMaleName.Click += new System.EventHandler(this.btnUpdateMaleName_Click);
            // 
            // pDisplay
            // 
            this.pDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pDisplay.Controls.Add(this.btnUpdateStartDate);
            this.pDisplay.Controls.Add(this.dtpStartDate);
            this.pDisplay.Controls.Add(this.btnUpdateFemaleName);
            this.pDisplay.Controls.Add(this.btnUpdateMaleName);
            this.pDisplay.Controls.Add(this.txtFemale);
            this.pDisplay.Controls.Add(this.txtMale);
            this.pDisplay.Controls.Add(this.label3);
            this.pDisplay.Controls.Add(this.lblFemale);
            this.pDisplay.Controls.Add(this.picFemale);
            this.pDisplay.Controls.Add(this.picMale);
            this.pDisplay.Controls.Add(this.lblTotal);
            this.pDisplay.Controls.Add(this.lblTo);
            this.pDisplay.Controls.Add(this.lblStart);
            this.pDisplay.Controls.Add(this.lblMale);
            this.pDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDisplay.Location = new System.Drawing.Point(0, 31);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(316, 544);
            this.pDisplay.TabIndex = 10;
            this.pDisplay.Click += new System.EventHandler(this.pDisplay_Click);
            // 
            // btnUpdateStartDate
            // 
            this.btnUpdateStartDate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateStartDate.ErrorImage = null;
            this.btnUpdateStartDate.Image = global::Notice.Properties.Resources.checkmark_25px;
            this.btnUpdateStartDate.ImageActive = null;
            this.btnUpdateStartDate.InitialImage = null;
            this.btnUpdateStartDate.Location = new System.Drawing.Point(140, 501);
            this.btnUpdateStartDate.Name = "btnUpdateStartDate";
            this.btnUpdateStartDate.Size = new System.Drawing.Size(24, 26);
            this.btnUpdateStartDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdateStartDate.TabIndex = 20;
            this.btnUpdateStartDate.TabStop = false;
            this.btnUpdateStartDate.Zoom = 15;
            this.btnUpdateStartDate.Click += new System.EventHandler(this.btnUpdateStartDate_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(6, 503);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(134, 24);
            this.dtpStartDate.TabIndex = 19;
            // 
            // btnUpdateFemaleName
            // 
            this.btnUpdateFemaleName.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFemaleName.ErrorImage = null;
            this.btnUpdateFemaleName.Image = global::Notice.Properties.Resources.checkmark_25px;
            this.btnUpdateFemaleName.ImageActive = null;
            this.btnUpdateFemaleName.InitialImage = null;
            this.btnUpdateFemaleName.Location = new System.Drawing.Point(169, 314);
            this.btnUpdateFemaleName.Name = "btnUpdateFemaleName";
            this.btnUpdateFemaleName.Size = new System.Drawing.Size(24, 26);
            this.btnUpdateFemaleName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdateFemaleName.TabIndex = 18;
            this.btnUpdateFemaleName.TabStop = false;
            this.btnUpdateFemaleName.Zoom = 15;
            this.btnUpdateFemaleName.Click += new System.EventHandler(this.btnUpdateFemaleName_Click);
            // 
            // txtFemale
            // 
            this.txtFemale.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFemale.Location = new System.Drawing.Point(193, 316);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(121, 24);
            this.txtFemale.TabIndex = 17;
            // 
            // txtMale
            // 
            this.txtMale.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMale.Location = new System.Drawing.Point(1, 316);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(121, 24);
            this.txtMale.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Hanuman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Together for";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFemale
            // 
            this.lblFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFemale.Location = new System.Drawing.Point(194, 313);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(122, 16);
            this.lblFemale.TabIndex = 14;
            this.lblFemale.Text = "Her Name";
            this.lblFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFemale.Click += new System.EventHandler(this.lblFemale_Click);
            // 
            // picFemale
            // 
            this.picFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFemale.Image = global::Notice.Properties.Resources.bride_and_groom;
            this.picFemale.Location = new System.Drawing.Point(189, 202);
            this.picFemale.Name = "picFemale";
            this.picFemale.Size = new System.Drawing.Size(108, 108);
            this.picFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFemale.TabIndex = 13;
            this.picFemale.TabStop = false;
            this.picFemale.Click += new System.EventHandler(this.picFemale_Click);
            // 
            // picMale
            // 
            this.picMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMale.Image = global::Notice.Properties.Resources.bride_and_groom;
            this.picMale.Location = new System.Drawing.Point(13, 202);
            this.picMale.Name = "picMale";
            this.picMale.Size = new System.Drawing.Size(108, 108);
            this.picMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMale.TabIndex = 12;
            this.picMale.TabStop = false;
            this.picMale.Click += new System.EventHandler(this.picMale_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Hanuman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(316, 31);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = " .";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(1, 153);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(313, 24);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = " .";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Location = new System.Drawing.Point(201, 509);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(111, 16);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Sunday, 29 July 2018";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblMale
            // 
            this.lblMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMale.Location = new System.Drawing.Point(2, 313);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(119, 16);
            this.lblMale.TabIndex = 7;
            this.lblMale.Text = "Your Name";
            this.lblMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMale.Click += new System.EventHandler(this.lblMale_Click);
            // 
            // Man
            // 
            this.Man.ElipseRadius = 100;
            this.Man.TargetControl = this.picMale;
            // 
            // Female
            // 
            this.Female.ElipseRadius = 100;
            this.Female.TargetControl = this.picFemale;
            // 
            // frmLoveCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notice.Properties.Resources.Love;
            this.ClientSize = new System.Drawing.Size(316, 575);
            this.ControlBox = false;
            this.Controls.Add(this.pDisplay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hanuman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoveCount";
            this.Text = "frmLoveCount";
            this.Load += new System.EventHandler(this.frmLoveCount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateMaleName)).EndInit();
            this.pDisplay.ResumeLayout(false);
            this.pDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateFemaleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdateMaleName;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel pDisplay;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.PictureBox picFemale;
        private System.Windows.Forms.PictureBox picMale;
        private Bunifu.Framework.UI.BunifuElipse Man;
        private Bunifu.Framework.UI.BunifuElipse Female;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMale;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFemale;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdateFemaleName;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdateStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}