namespace Main
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnNotice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnNotice
            // 
            this.btnNotice.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotice.BorderRadius = 0;
            this.btnNotice.ButtonText = "Notice";
            this.btnNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotice.DisabledColor = System.Drawing.Color.Gray;
            this.btnNotice.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNotice.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNotice.Iconimage")));
            this.btnNotice.Iconimage_right = null;
            this.btnNotice.Iconimage_right_Selected = null;
            this.btnNotice.Iconimage_Selected = null;
            this.btnNotice.IconMarginLeft = 0;
            this.btnNotice.IconMarginRight = 0;
            this.btnNotice.IconRightVisible = true;
            this.btnNotice.IconRightZoom = 0D;
            this.btnNotice.IconVisible = true;
            this.btnNotice.IconZoom = 90D;
            this.btnNotice.IsTab = false;
            this.btnNotice.Location = new System.Drawing.Point(12, 4);
            this.btnNotice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNotice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNotice.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNotice.selected = false;
            this.btnNotice.Size = new System.Drawing.Size(102, 30);
            this.btnNotice.TabIndex = 0;
            this.btnNotice.Text = "Notice";
            this.btnNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotice.Textcolor = System.Drawing.Color.White;
            this.btnNotice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotice.Click += new System.EventHandler(this.BtnNotice_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 183);
            this.Controls.Add(this.btnNotice);
            this.Font = new System.Drawing.Font("Hanuman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnNotice;
    }
}