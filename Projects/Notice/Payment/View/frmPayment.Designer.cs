namespace Notice.Payment.View
{
    partial class frmPayment
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
            Janus.Windows.GridEX.GridEXLayout gridListPayment_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNew = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridListPayment = new Janus.Windows.GridEX.GridEX();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblItems = new System.Windows.Forms.Label();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtItems = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 31);
            this.panel1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ErrorImage = null;
            this.btnSave.Image = global::Notice.Properties.Resources.checkmark_25px;
            this.btnSave.ImageActive = null;
            this.btnSave.InitialImage = null;
            this.btnSave.Location = new System.Drawing.Point(288, 2);
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
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ErrorImage = null;
            this.btnNew.Image = global::Notice.Properties.Resources.plus_25px;
            this.btnNew.ImageActive = null;
            this.btnNew.InitialImage = null;
            this.btnNew.Location = new System.Drawing.Point(288, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(24, 26);
            this.btnNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNew.TabIndex = 9;
            this.btnNew.TabStop = false;
            this.btnNew.Zoom = 15;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridListPayment);
            this.panel2.Controls.Add(this.lblPaymentDate);
            this.panel2.Controls.Add(this.lblDes);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtItems);
            this.panel2.Controls.Add(this.dtpPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 544);
            this.panel2.TabIndex = 10;
            // 
            // gridListPayment
            // 
            this.gridListPayment.AllowDrop = true;
            this.gridListPayment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListPayment.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListPayment.ColumnAutoResize = true;
            gridListPayment_DesignTimeLayout.LayoutString = resources.GetString("gridListPayment_DesignTimeLayout.LayoutString");
            this.gridListPayment.DesignTimeLayout = gridListPayment_DesignTimeLayout;
            this.gridListPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListPayment.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridListPayment.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridListPayment.Location = new System.Drawing.Point(0, 0);
            this.gridListPayment.Name = "gridListPayment";
            this.gridListPayment.Size = new System.Drawing.Size(316, 544);
            this.gridListPayment.TabIndex = 39;
            this.gridListPayment.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListPayment.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.gridListPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridListPayment.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridListPayment_RowDoubleClick);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 10);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(76, 16);
            this.lblPaymentDate.TabIndex = 38;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 182);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(62, 16);
            this.lblDes.TabIndex = 37;
            this.lblDes.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 16);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPrice.Location = new System.Drawing.Point(15, 151);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(289, 24);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(12, 58);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(46, 16);
            this.lblItems.TabIndex = 34;
            this.lblItems.Text = "Product";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.Location = new System.Drawing.Point(15, 201);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 332);
            this.txtDescription.TabIndex = 3;
            // 
            // txtItems
            // 
            this.txtItems.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtItems.Location = new System.Drawing.Point(15, 77);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(289, 52);
            this.txtItems.TabIndex = 1;
            // 
            // dtpPayment
            // 
            this.dtpPayment.CustomFormat = "dd/MM/yyyy";
            this.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayment.Location = new System.Drawing.Point(15, 29);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(289, 24);
            this.dtpPayment.TabIndex = 0;
            // 
            // frmPayment
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
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnNew;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPrice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPrice;
        private System.Windows.Forms.Label lblItems;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtItems;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private Janus.Windows.GridEX.GridEX gridListPayment;
    }
}