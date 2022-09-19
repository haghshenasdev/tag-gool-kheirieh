namespace kheirieh_app_winform.Accounting.dialog.tarh
{
    partial class FRMChoseTarh
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgtarhs = new System.Windows.Forms.DataGridView();
            this.idtarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarhpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(453, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(290, 21);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "جستجو:";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(639, 312);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(176, 23);
            this.BtnOk.TabIndex = 15;
            this.BtnOk.Text = "انتخاب";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.dgtarhs.Location = new System.Drawing.Point(453, 47);
            this.dgtarhs.Name = "dgtarhs";
            this.dgtarhs.ReadOnly = true;
            this.dgtarhs.Size = new System.Drawing.Size(362, 259);
            this.dgtarhs.TabIndex = 20;
            this.dgtarhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtarhs_CellClick);
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
            this.tarhpic.Location = new System.Drawing.Point(12, 18);
            this.tarhpic.Name = "tarhpic";
            this.tarhpic.Size = new System.Drawing.Size(420, 317);
            this.tarhpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tarhpic.TabIndex = 21;
            this.tarhpic.TabStop = false;
            // 
            // FRMChoseTarh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 357);
            this.Controls.Add(this.tarhpic);
            this.Controls.Add(this.dgtarhs);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMChoseTarh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب طرح";
            this.Load += new System.EventHandler(this.FRMChoseTarh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgtarhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.PictureBox tarhpic;
    }
}