namespace kheirieh_app_winform
{
    partial class FRMInestallTarh
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
            this.button1 = new System.Windows.Forms.Button();
            this.btndeltarh = new System.Windows.Forms.Button();
            this.dgtarhs = new System.Windows.Forms.DataGridView();
            this.idtarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarhpic = new System.Windows.Forms.PictureBox();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن بسته گرافیکی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndeltarh
            // 
            this.btndeltarh.Location = new System.Drawing.Point(570, 460);
            this.btndeltarh.Name = "btndeltarh";
            this.btndeltarh.Size = new System.Drawing.Size(180, 25);
            this.btndeltarh.TabIndex = 3;
            this.btndeltarh.Text = "حذف طرح";
            this.btndeltarh.UseVisualStyleBackColor = true;
            this.btndeltarh.Click += new System.EventHandler(this.btndeltarh_Click);
            // 
            // dgtarhs
            // 
            this.dgtarhs.AllowUserToAddRows = false;
            this.dgtarhs.AllowUserToDeleteRows = false;
            this.dgtarhs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtarhs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgtarhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtarhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtarh,
            this.nametarh,
            this.path});
            this.dgtarhs.Location = new System.Drawing.Point(388, 43);
            this.dgtarhs.Name = "dgtarhs";
            this.dgtarhs.ReadOnly = true;
            this.dgtarhs.Size = new System.Drawing.Size(362, 411);
            this.dgtarhs.TabIndex = 4;
            this.dgtarhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtarhs_CellContentClick);
            // 
            // idtarh
            // 
            this.idtarh.DataPropertyName = "id";
            this.idtarh.HeaderText = "id";
            this.idtarh.Name = "idtarh";
            this.idtarh.ReadOnly = true;
            this.idtarh.Visible = false;
            // 
            // nametarh
            // 
            this.nametarh.DataPropertyName = "name";
            this.nametarh.HeaderText = "طرح";
            this.nametarh.Name = "nametarh";
            this.nametarh.ReadOnly = true;
            // 
            // path
            // 
            this.path.DataPropertyName = "path";
            this.path.HeaderText = "مسیر فایل";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            // 
            // tarhpic
            // 
            this.tarhpic.ErrorImage = global::kheirieh_app_winform.Properties.Resources.loding2;
            this.tarhpic.Image = global::kheirieh_app_winform.Properties.Resources._500_500;
            this.tarhpic.InitialImage = global::kheirieh_app_winform.Properties.Resources.loding2;
            this.tarhpic.Location = new System.Drawing.Point(12, 12);
            this.tarhpic.Name = "tarhpic";
            this.tarhpic.Size = new System.Drawing.Size(359, 473);
            this.tarhpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tarhpic.TabIndex = 5;
            this.tarhpic.TabStop = false;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(388, 460);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(176, 25);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "ویرایش طرح";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // FRMInestallTarh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 497);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.tarhpic);
            this.Controls.Add(this.dgtarhs);
            this.Controls.Add(this.btndeltarh);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMInestallTarh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت طرح ها";
            this.Load += new System.EventHandler(this.FRMInestallTarh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndeltarh;
        private System.Windows.Forms.DataGridView dgtarhs;
        private System.Windows.Forms.PictureBox tarhpic;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.Button btnedit;
    }
}