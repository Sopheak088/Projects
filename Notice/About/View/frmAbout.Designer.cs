namespace Notice.About.View
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnEditOffOn = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnEditOffOn);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 68);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 509);
            this.panel2.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Hanuman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(0, 3);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(315, 543);
            this.txtNote.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Notice.Properties.Resources.money_bag;
            this.picLogo.Location = new System.Drawing.Point(121, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(75, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnEditOffOn
            // 
            this.btnEditOffOn.BackColor = System.Drawing.Color.Transparent;
            this.btnEditOffOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditOffOn.BackgroundImage")));
            this.btnEditOffOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOffOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOffOn.Location = new System.Drawing.Point(247, 4);
            this.btnEditOffOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditOffOn.Name = "btnEditOffOn";
            this.btnEditOffOn.OffColor = System.Drawing.Color.Gray;
            this.btnEditOffOn.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.btnEditOffOn.Size = new System.Drawing.Size(35, 20);
            this.btnEditOffOn.TabIndex = 9;
            this.btnEditOffOn.Value = false;
            this.btnEditOffOn.OnValueChange += new System.EventHandler(this.btnEditOffOn_OnValueChange);
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
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hanuman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAbout";
            this.Text = "frmNote";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNote;
        private Bunifu.Framework.UI.BunifuiOSSwitch btnEditOffOn;
        private System.Windows.Forms.PictureBox picLogo;
    }
}