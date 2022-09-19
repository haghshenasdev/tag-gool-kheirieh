namespace kheirieh_app_winform
{
    partial class FRMSeting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TarhRand = new System.Windows.Forms.CheckBox();
            this.DefualtTypeTXT = new System.Windows.Forms.TextBox();
            this.DefualtTarhTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tarhsearch = new System.Windows.Forms.TextBox();
            this.dgtarhs = new System.Windows.Forms.DataGridView();
            this.idtarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.typesearch = new System.Windows.Forms.TextBox();
            this.dgtajtype = new System.Windows.Forms.DataGridView();
            this.idtaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nLimittable = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbrose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtajtype)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimittable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbrose);
            this.groupBox1.Controls.Add(this.txtpath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TarhRand);
            this.groupBox1.Controls.Add(this.DefualtTypeTXT);
            this.groupBox1.Controls.Add(this.DefualtTarhTXT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مقادیر پیش فرض";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TarhRand
            // 
            this.TarhRand.AutoSize = true;
            this.TarhRand.Location = new System.Drawing.Point(12, 37);
            this.TarhRand.Name = "TarhRand";
            this.TarhRand.Size = new System.Drawing.Size(109, 18);
            this.TarhRand.TabIndex = 5;
            this.TarhRand.Text = "انتخاب تصادفی";
            this.TarhRand.UseVisualStyleBackColor = true;
            this.TarhRand.CheckedChanged += new System.EventHandler(this.TarhRand_CheckedChanged);
            // 
            // DefualtTypeTXT
            // 
            this.DefualtTypeTXT.Enabled = false;
            this.DefualtTypeTXT.Location = new System.Drawing.Point(10, 76);
            this.DefualtTypeTXT.Name = "DefualtTypeTXT";
            this.DefualtTypeTXT.Size = new System.Drawing.Size(243, 21);
            this.DefualtTypeTXT.TabIndex = 4;
            this.DefualtTypeTXT.TextChanged += new System.EventHandler(this.DefualtTypeTXT_TextChanged);
            this.DefualtTypeTXT.Enter += new System.EventHandler(this.DefualtTypeTXT_Enter);
            // 
            // DefualtTarhTXT
            // 
            this.DefualtTarhTXT.Enabled = false;
            this.DefualtTarhTXT.Location = new System.Drawing.Point(127, 35);
            this.DefualtTarhTXT.Name = "DefualtTarhTXT";
            this.DefualtTarhTXT.Size = new System.Drawing.Size(128, 21);
            this.DefualtTarhTXT.TabIndex = 3;
            this.DefualtTarhTXT.Enter += new System.EventHandler(this.DefualtTarhTXT_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نوع پیش فرض : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرح پیش فرض : ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(255, 333);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tarhsearch);
            this.tabPage1.Controls.Add(this.dgtarhs);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "طرح ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "جستجو:";
            // 
            // tarhsearch
            // 
            this.tarhsearch.Location = new System.Drawing.Point(6, 12);
            this.tarhsearch.Name = "tarhsearch";
            this.tarhsearch.Size = new System.Drawing.Size(177, 21);
            this.tarhsearch.TabIndex = 5;
            this.tarhsearch.TextChanged += new System.EventHandler(this.tarhsearch_TextChanged);
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
            this.dgtarhs.Location = new System.Drawing.Point(3, 40);
            this.dgtarhs.Name = "dgtarhs";
            this.dgtarhs.ReadOnly = true;
            this.dgtarhs.Size = new System.Drawing.Size(241, 263);
            this.dgtarhs.TabIndex = 4;
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
            this.path.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.typesearch);
            this.tabPage2.Controls.Add(this.dgtajtype);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "نوع تاج گل";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "جستجو:";
            // 
            // typesearch
            // 
            this.typesearch.Location = new System.Drawing.Point(6, 12);
            this.typesearch.Name = "typesearch";
            this.typesearch.Size = new System.Drawing.Size(177, 21);
            this.typesearch.TabIndex = 7;
            this.typesearch.TextChanged += new System.EventHandler(this.typesearch_TextChanged);
            // 
            // dgtajtype
            // 
            this.dgtajtype.AllowUserToAddRows = false;
            this.dgtajtype.AllowUserToDeleteRows = false;
            this.dgtajtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtajtype.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgtajtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtajtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaj,
            this.typename,
            this.amount,
            this.count});
            this.dgtajtype.Location = new System.Drawing.Point(3, 39);
            this.dgtajtype.Name = "dgtajtype";
            this.dgtajtype.ReadOnly = true;
            this.dgtajtype.Size = new System.Drawing.Size(241, 264);
            this.dgtajtype.TabIndex = 3;
            this.dgtajtype.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtajtype_CellClick);
            // 
            // idtaj
            // 
            this.idtaj.DataPropertyName = "id";
            this.idtaj.HeaderText = "Column1";
            this.idtaj.Name = "idtaj";
            this.idtaj.ReadOnly = true;
            this.idtaj.Visible = false;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "نوع";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "مبلغ";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "تعداد";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(557, 325);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(476, 325);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nLimittable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(273, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جداول";
            // 
            // nLimittable
            // 
            this.nLimittable.Location = new System.Drawing.Point(12, 31);
            this.nLimittable.Name = "nLimittable";
            this.nLimittable.Size = new System.Drawing.Size(132, 21);
            this.nLimittable.TabIndex = 8;
            this.nLimittable.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "تعداد محدود سازی نمایش جداول : ";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(108, 144);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(240, 21);
            this.txtpath.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "مسیر ذخیره سازی و فراخوانی طرح ها :";
            // 
            // btnbrose
            // 
            this.btnbrose.Location = new System.Drawing.Point(12, 144);
            this.btnbrose.Name = "btnbrose";
            this.btnbrose.Size = new System.Drawing.Size(90, 23);
            this.btnbrose.TabIndex = 8;
            this.btnbrose.Text = "انتخاب مسیر";
            this.btnbrose.UseVisualStyleBackColor = true;
            this.btnbrose.Click += new System.EventHandler(this.btnbrose_Click);
            // 
            // FRMSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMSeting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.FRMSeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtajtype)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimittable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DefualtTypeTXT;
        private System.Windows.Forms.TextBox DefualtTarhTXT;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.CheckBox TarhRand;
        private System.Windows.Forms.DataGridView dgtarhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridView dgtajtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nLimittable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tarhsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typesearch;
        private System.Windows.Forms.Button btnbrose;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label6;
    }
}