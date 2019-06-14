namespace Notice.Note.View
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
            Janus.Windows.GridEX.GridEXLayout gridNote_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoveCount));
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoteDate = new System.Windows.Forms.Label();
            this.btnNew = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtpNote = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridNote = new Janus.Windows.GridEX.GridEX();
            this.txtNote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNote)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblNoteDate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.dtpNote);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 31);
            this.panel1.TabIndex = 8;
            // 
            // lblNoteDate
            // 
            this.lblNoteDate.AutoSize = true;
            this.lblNoteDate.Font = new System.Drawing.Font("Hanuman", 9.25F);
            this.lblNoteDate.Location = new System.Drawing.Point(64, 8);
            this.lblNoteDate.Name = "lblNoteDate";
            this.lblNoteDate.Size = new System.Drawing.Size(36, 19);
            this.lblNoteDate.TabIndex = 15;
            this.lblNoteDate.Text = "Note";
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
            // dtpNote
            // 
            this.dtpNote.CustomFormat = "dd/MM/yyyy";
            this.dtpNote.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNote.Location = new System.Drawing.Point(106, 3);
            this.dtpNote.Name = "dtpNote";
            this.dtpNote.Size = new System.Drawing.Size(98, 24);
            this.dtpNote.TabIndex = 9;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridNote);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 546);
            this.panel2.TabIndex = 9;
            // 
            // gridNote
            // 
            this.gridNote.AllowDrop = true;
            this.gridNote.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridNote.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridNote.ColumnAutoResize = true;
            gridNote_DesignTimeLayout.LayoutString = resources.GetString("gridNote_DesignTimeLayout.LayoutString");
            this.gridNote.DesignTimeLayout = gridNote_DesignTimeLayout;
            this.gridNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNote.FilterMode = Janus.Windows.GridEX.FilterMode.Manual;
            this.gridNote.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.None;
            this.gridNote.Location = new System.Drawing.Point(0, 0);
            this.gridNote.Name = "gridNote";
            this.gridNote.Size = new System.Drawing.Size(315, 546);
            this.gridNote.TabIndex = 1;
            this.gridNote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.gridNote.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridNote_RowDoubleClick);
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Hanuman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(315, 546);
            this.txtNote.TabIndex = 0;
            // 
            // frmLoveCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hanuman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoveCount";
            this.Text = "frmNote";
            this.Load += new System.EventHandler(this.frmNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpNote;
        private Janus.Windows.GridEX.GridEX gridNote;
        private Bunifu.Framework.UI.BunifuImageButton btnNew;
        private System.Windows.Forms.Label lblNoteDate;
    }
}