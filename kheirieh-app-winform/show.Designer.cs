namespace kheirieh_app_winform
{
    partial class show
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
            this.picview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // picview
            // 
            this.picview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picview.Location = new System.Drawing.Point(0, 0);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(800, 450);
            this.picview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picview.TabIndex = 0;
            this.picview.TabStop = false;
            // 
            // show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picview);
            this.Name = "show";
            this.Text = "show";
            this.Load += new System.EventHandler(this.show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picview;
    }
}