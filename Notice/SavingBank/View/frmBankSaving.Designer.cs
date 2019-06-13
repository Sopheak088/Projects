namespace Notice.SavingBank.View
{
    partial class frmBankSaving
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
            Janus.Windows.GridEX.GridEXLayout gridListBank_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankSaving));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAmount = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCashOut = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCashIn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gridListBank = new Janus.Windows.GridEX.GridEX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.pDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListBank)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 31);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ErrorImage = null;
            this.btnSave.Image = global::Notice.Properties.Resources.checkmark_25px;
            this.btnSave.ImageActive = null;
            this.btnSave.InitialImage = null;
            this.btnSave.Location = new System.Drawing.Point(289, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 26);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 15;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.panel2.Controls.Add(this.pDisplay);
            this.panel2.Controls.Add(this.btnCashOut);
            this.panel2.Controls.Add(this.btnCashIn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 544);
            this.panel2.TabIndex = 11;
            // 
            // pDisplay
            // 
            this.pDisplay.Controls.Add(this.gridListBank);
            this.pDisplay.Controls.Add(this.lblPaymentDate);
            this.pDisplay.Controls.Add(this.lblDes);
            this.pDisplay.Controls.Add(this.lblPrice);
            this.pDisplay.Controls.Add(this.txtAmount);
            this.pDisplay.Controls.Add(this.txtDescription);
            this.pDisplay.Controls.Add(this.dtpDate);
            this.pDisplay.Location = new System.Drawing.Point(0, 33);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(315, 511);
            this.pDisplay.TabIndex = 2;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 12);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(30, 16);
            this.lblPaymentDate.TabIndex = 44;
            this.lblPaymentDate.Text = "Date";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 110);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(62, 16);
            this.lblDes.TabIndex = 43;
            this.lblDes.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAmount.Location = new System.Drawing.Point(15, 79);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(289, 24);
            this.txtAmount.TabIndex = 40;
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.Location = new System.Drawing.Point(15, 129);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 370);
            this.txtDescription.TabIndex = 41;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(15, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(289, 24);
            this.dtpDate.TabIndex = 39;
            // 
            // btnCashOut
            // 
            this.btnCashOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCashOut.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashOut.Location = new System.Drawing.Point(161, 3);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(144, 26);
            this.btnCashOut.TabIndex = 1;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnCashIn
            // 
            this.btnCashIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCashIn.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashIn.Location = new System.Drawing.Point(11, 3);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(144, 26);
            this.btnCashIn.TabIndex = 0;
            this.btnCashIn.Text = "Cash In";
            this.btnCashIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // gridListBank
            // 
            this.gridListBank.AllowDrop = true;
            this.gridListBank.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListBank.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListBank.ColumnAutoResize = true;
            gridListBank_DesignTimeLayout.LayoutString = resources.GetString("gridListBank_DesignTimeLayout.LayoutString");
            this.gridListBank.DesignTimeLayout = gridListBank_DesignTimeLayout;
            this.gridListBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListBank.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridListBank.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridListBank.Location = new System.Drawing.Point(0, 0);
            this.gridListBank.Name = "gridListBank";
            this.gridListBank.Size = new System.Drawing.Size(315, 511);
            this.gridListBank.TabIndex = 45;
            this.gridListBank.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.gridListBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridListBank.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridListBank_RowDoubleClick);
            // 
            // frmBank
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
            this.Name = "frmBank";
            this.Text = "frmIncome";
            this.Load += new System.EventHandler(this.frmBankSaving_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pDisplay.ResumeLayout(false);
            this.pDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel btnCashOut;
        private Bunifu.Framework.UI.BunifuCustomLabel btnCashIn;
        private System.Windows.Forms.Panel pDisplay;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPrice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAmount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Janus.Windows.GridEX.GridEX gridListBank;
    }
}