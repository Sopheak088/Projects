namespace Notice.Gallery.View
{
    partial class frmGallery
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRotateRight = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRotateLeft = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnUpload = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.ctmSavePic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.savePic = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllPic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotateRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotateLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.ctmSavePic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnRotateRight);
            this.panel2.Controls.Add(this.btnRotateLeft);
            this.panel2.Controls.Add(this.lblNum);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.picShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 575);
            this.panel2.TabIndex = 10;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRotateRight.ErrorImage = null;
            this.btnRotateRight.Image = global::Notice.Properties.Resources.rotate_right_25px_1;
            this.btnRotateRight.ImageActive = null;
            this.btnRotateRight.InitialImage = null;
            this.btnRotateRight.Location = new System.Drawing.Point(134, 546);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(24, 26);
            this.btnRotateRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRotateRight.TabIndex = 12;
            this.btnRotateRight.TabStop = false;
            this.btnRotateRight.Zoom = 15;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnRotateLeft.ErrorImage = null;
            this.btnRotateLeft.Image = global::Notice.Properties.Resources.rotate_left_25px_1;
            this.btnRotateLeft.ImageActive = null;
            this.btnRotateLeft.InitialImage = null;
            this.btnRotateLeft.Location = new System.Drawing.Point(162, 546);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(24, 26);
            this.btnRotateLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRotateLeft.TabIndex = 11;
            this.btnRotateLeft.TabStop = false;
            this.btnRotateLeft.Zoom = 15;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNum.Location = new System.Drawing.Point(24, 1);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(262, 25);
            this.lblNum.TabIndex = 10;
            this.lblNum.Text = "1";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.ErrorImage = null;
            this.btnUpload.Image = global::Notice.Properties.Resources.upload_25px_1;
            this.btnUpload.ImageActive = null;
            this.btnUpload.InitialImage = null;
            this.btnUpload.Location = new System.Drawing.Point(290, 0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(24, 26);
            this.btnUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpload.TabIndex = 8;
            this.btnUpload.TabStop = false;
            this.btnUpload.Zoom = 15;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.ErrorImage = null;
            this.btnNext.Image = global::Notice.Properties.Resources.next_25px;
            this.btnNext.ImageActive = null;
            this.btnNext.InitialImage = null;
            this.btnNext.Location = new System.Drawing.Point(194, 546);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 26);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 9;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 15;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.ErrorImage = null;
            this.btnBack.Image = global::Notice.Properties.Resources.previous_25px;
            this.btnBack.ImageActive = null;
            this.btnBack.InitialImage = null;
            this.btnBack.Location = new System.Drawing.Point(2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 26);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 7;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 15;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.ErrorImage = null;
            this.btnPrevious.Image = global::Notice.Properties.Resources.previous_25px_1;
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.InitialImage = null;
            this.btnPrevious.Location = new System.Drawing.Point(102, 546);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 26);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 15;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // picShow
            // 
            this.picShow.ContextMenuStrip = this.ctmSavePic;
            this.picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShow.Location = new System.Drawing.Point(0, 0);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(316, 575);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // ctmSavePic
            // 
            this.ctmSavePic.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmSavePic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePic,
            this.saveAllPic});
            this.ctmSavePic.Name = "ctmSavePic";
            this.ctmSavePic.Size = new System.Drawing.Size(221, 68);
            // 
            // savePic
            // 
            this.savePic.Image = global::Notice.Properties.Resources.save;
            this.savePic.Name = "savePic";
            this.savePic.Size = new System.Drawing.Size(220, 32);
            this.savePic.Text = "Save Picture";
            this.savePic.Click += new System.EventHandler(this.savePic_Click);
            // 
            // saveAllPic
            // 
            this.saveAllPic.Image = global::Notice.Properties.Resources.transfer_item;
            this.saveAllPic.Name = "saveAllPic";
            this.saveAllPic.Size = new System.Drawing.Size(220, 32);
            this.saveAllPic.Text = "Save All Pictures";
            this.saveAllPic.Click += new System.EventHandler(this.saveAllPic_Click);
            // 
            // frmGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 575);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGallery";
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.frmGallery_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRotateRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotateLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ctmSavePic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnUpload;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picShow;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ContextMenuStrip ctmSavePic;
        private System.Windows.Forms.ToolStripMenuItem savePic;
        private System.Windows.Forms.ToolStripMenuItem saveAllPic;
        private Bunifu.Framework.UI.BunifuImageButton btnRotateRight;
        private Bunifu.Framework.UI.BunifuImageButton btnRotateLeft;
    }
}