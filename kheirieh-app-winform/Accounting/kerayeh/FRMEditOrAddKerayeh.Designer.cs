namespace kheirieh_app_winform.Accounting.kerayeh
{
    partial class FRMEditOrAddKerayeh
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChoseMarhoom = new System.Windows.Forms.Button();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChosePerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChoseTarh = new System.Windows.Forms.Button();
            this.btnchoseType = new System.Windows.Forms.Button();
            this.dateshow = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttarh = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nAmount = new System.Windows.Forms.NumericUpDown();
            this.ispardakht = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelTarh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(244, 537);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(140, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "افزودن";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(98, 537);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(140, 23);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "صرف نظر کردن";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChoseMarhoom);
            this.groupBox1.Controls.Add(this.txtmName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مرحوم";
            // 
            // btnChoseMarhoom
            // 
            this.btnChoseMarhoom.Location = new System.Drawing.Point(6, 35);
            this.btnChoseMarhoom.Name = "btnChoseMarhoom";
            this.btnChoseMarhoom.Size = new System.Drawing.Size(88, 23);
            this.btnChoseMarhoom.TabIndex = 11;
            this.btnChoseMarhoom.Text = "انتخاب";
            this.btnChoseMarhoom.UseVisualStyleBackColor = true;
            this.btnChoseMarhoom.Click += new System.EventHandler(this.btnChoseMarhoom_Click);
            // 
            // txtmName
            // 
            this.txtmName.Enabled = false;
            this.txtmName.Location = new System.Drawing.Point(100, 36);
            this.txtmName.Name = "txtmName";
            this.txtmName.Size = new System.Drawing.Size(262, 21);
            this.txtmName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChosePerson);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txttName);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات طرف";
            // 
            // btnChosePerson
            // 
            this.btnChosePerson.Location = new System.Drawing.Point(6, 23);
            this.btnChosePerson.Name = "btnChosePerson";
            this.btnChosePerson.Size = new System.Drawing.Size(88, 23);
            this.btnChosePerson.TabIndex = 12;
            this.btnChosePerson.Text = "انتخاب";
            this.btnChosePerson.UseVisualStyleBackColor = true;
            this.btnChosePerson.Click += new System.EventHandler(this.btnChosePerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام :";
            // 
            // txttName
            // 
            this.txttName.Enabled = false;
            this.txttName.Location = new System.Drawing.Point(100, 24);
            this.txttName.Name = "txttName";
            this.txttName.Size = new System.Drawing.Size(262, 21);
            this.txttName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelTarh);
            this.groupBox3.Controls.Add(this.btnChoseTarh);
            this.groupBox3.Controls.Add(this.btnchoseType);
            this.groupBox3.Controls.Add(this.dateshow);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.txttarh);
            this.groupBox3.Controls.Add(this.txttype);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 186);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات چاپ";
            // 
            // btnChoseTarh
            // 
            this.btnChoseTarh.Location = new System.Drawing.Point(6, 130);
            this.btnChoseTarh.Name = "btnChoseTarh";
            this.btnChoseTarh.Size = new System.Drawing.Size(88, 23);
            this.btnChoseTarh.TabIndex = 10;
            this.btnChoseTarh.Text = "انتخاب";
            this.btnChoseTarh.UseVisualStyleBackColor = true;
            this.btnChoseTarh.Click += new System.EventHandler(this.btnChoseTarh_Click);
            // 
            // btnchoseType
            // 
            this.btnchoseType.Location = new System.Drawing.Point(6, 97);
            this.btnchoseType.Name = "btnchoseType";
            this.btnchoseType.Size = new System.Drawing.Size(88, 23);
            this.btnchoseType.TabIndex = 9;
            this.btnchoseType.Text = "انتخاب";
            this.btnchoseType.UseVisualStyleBackColor = true;
            this.btnchoseType.Click += new System.EventHandler(this.btnchoseType_Click);
            // 
            // dateshow
            // 
            this.dateshow.AutoSize = true;
            this.dateshow.Location = new System.Drawing.Point(6, 69);
            this.dateshow.Name = "dateshow";
            this.dateshow.Size = new System.Drawing.Size(37, 14);
            this.dateshow.TabIndex = 8;
            this.dateshow.Text = "label8";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txttarh
            // 
            this.txttarh.Enabled = false;
            this.txttarh.Location = new System.Drawing.Point(194, 130);
            this.txttarh.Name = "txttarh";
            this.txttarh.Size = new System.Drawing.Size(168, 21);
            this.txttarh.TabIndex = 6;
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Location = new System.Drawing.Point(100, 99);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(262, 21);
            this.txttype.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "تاریخ چاپ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "نوع تاج گل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "طرح :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nCount);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.nAmount);
            this.groupBox4.Controls.Add(this.ispardakht);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 127);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اطلاعات مالی";
            // 
            // nCount
            // 
            this.nCount.Location = new System.Drawing.Point(6, 57);
            this.nCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(356, 21);
            this.nCount.TabIndex = 11;
            this.nCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "تعداد :";
            // 
            // nAmount
            // 
            this.nAmount.Location = new System.Drawing.Point(6, 26);
            this.nAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nAmount.Name = "nAmount";
            this.nAmount.Size = new System.Drawing.Size(356, 21);
            this.nAmount.TabIndex = 9;
            // 
            // ispardakht
            // 
            this.ispardakht.AutoSize = true;
            this.ispardakht.Location = new System.Drawing.Point(232, 94);
            this.ispardakht.Name = "ispardakht";
            this.ispardakht.Size = new System.Drawing.Size(99, 18);
            this.ispardakht.TabIndex = 8;
            this.ispardakht.Text = "پرداخت شده";
            this.ispardakht.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "وضعیت پرداخت :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "مبلغ :";
            // 
            // btnDelTarh
            // 
            this.btnDelTarh.Location = new System.Drawing.Point(100, 130);
            this.btnDelTarh.Name = "btnDelTarh";
            this.btnDelTarh.Size = new System.Drawing.Size(88, 23);
            this.btnDelTarh.TabIndex = 11;
            this.btnDelTarh.Text = "حذف";
            this.btnDelTarh.UseVisualStyleBackColor = true;
            this.btnDelTarh.Click += new System.EventHandler(this.btnDelTarh_Click);
            // 
            // FRMEditOrAddKerayeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 575);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMEditOrAddKerayeh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کرایه جدید";
            this.Load += new System.EventHandler(this.FRMEditOrAddKerayeh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttarh;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.CheckBox ispardakht;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateshow;
        private System.Windows.Forms.NumericUpDown nAmount;
        private System.Windows.Forms.NumericUpDown nCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChoseMarhoom;
        private System.Windows.Forms.Button btnChosePerson;
        private System.Windows.Forms.Button btnChoseTarh;
        private System.Windows.Forms.Button btnchoseType;
        private System.Windows.Forms.Button btnDelTarh;
    }
}