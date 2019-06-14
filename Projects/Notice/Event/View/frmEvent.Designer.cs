namespace Notice.Event.View
{
    partial class frmEvent
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
            Janus.Windows.GridEX.GridEXLayout gridListEvent_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNew = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridListEvent = new Janus.Windows.GridEX.GridEX();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtEventName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListEvent)).BeginInit();
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
            this.panel2.Controls.Add(this.gridListEvent);
            this.panel2.Controls.Add(this.lblPaymentDate);
            this.panel2.Controls.Add(this.lblDes);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtEventName);
            this.panel2.Controls.Add(this.dtpEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 544);
            this.panel2.TabIndex = 10;
            // 
            // gridListEvent
            // 
            this.gridListEvent.AllowDrop = true;
            this.gridListEvent.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListEvent.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListEvent.ColumnAutoResize = true;
            gridListEvent_DesignTimeLayout.LayoutString = resources.GetString("gridListEvent_DesignTimeLayout.LayoutString");
            this.gridListEvent.DesignTimeLayout = gridListEvent_DesignTimeLayout;
            this.gridListEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListEvent.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridListEvent.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridListEvent.GroupByBoxVisible = false;
            this.gridListEvent.Location = new System.Drawing.Point(0, 0);
            this.gridListEvent.Name = "gridListEvent";
            this.gridListEvent.Size = new System.Drawing.Size(316, 544);
            this.gridListEvent.TabIndex = 39;
            this.gridListEvent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridListEvent.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridListPayment_RowDoubleClick);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 10);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(60, 16);
            this.lblPaymentDate.TabIndex = 38;
            this.lblPaymentDate.Text = "Event Date";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 135);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(62, 16);
            this.lblDes.TabIndex = 37;
            this.lblDes.Text = "Description";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(12, 58);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(66, 16);
            this.lblItems.TabIndex = 34;
            this.lblItems.Text = "Event Name";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.Location = new System.Drawing.Point(15, 154);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 379);
            this.txtDescription.TabIndex = 3;
            // 
            // txtEventName
            // 
            this.txtEventName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtEventName.Location = new System.Drawing.Point(15, 77);
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(289, 52);
            this.txtEventName.TabIndex = 1;
            // 
            // dtpEvent
            // 
            this.dtpEvent.CustomFormat = "dd/MM/yyyy";
            this.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent.Location = new System.Drawing.Point(15, 29);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(289, 24);
            this.dtpEvent.TabIndex = 0;
            // 
            // frmEvent
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
            this.Name = "frmEvent";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListEvent)).EndInit();
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
        private System.Windows.Forms.Label lblItems;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtEventName;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private Janus.Windows.GridEX.GridEX gridListEvent;
    }
}