namespace kheirieh_app_winform
{
    partial class SmartPrint
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHselectall = new System.Windows.Forms.CheckBox();
            this.Ncustom = new System.Windows.Forms.NumericUpDown();
            this.CHcustom = new System.Windows.Forms.CheckBox();
            this.btnextarct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalise = new System.Windows.Forms.Button();
            this.CHyear = new System.Windows.Forms.CheckBox();
            this.CHforteen = new System.Windows.Forms.CheckBox();
            this.CHweek = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btndel = new System.Windows.Forms.Button();
            this.btnStartPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ncustom)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(303, 428);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(19, 143);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(430, 260);
            this.checkedList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHselectall);
            this.groupBox1.Controls.Add(this.Ncustom);
            this.groupBox1.Controls.Add(this.CHcustom);
            this.groupBox1.Controls.Add(this.btnextarct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAnalise);
            this.groupBox1.Controls.Add(this.checkedList);
            this.groupBox1.Controls.Add(this.CHyear);
            this.groupBox1.Controls.Add(this.CHforteen);
            this.groupBox1.Controls.Add(this.CHweek);
            this.groupBox1.Location = new System.Drawing.Point(321, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // CHselectall
            // 
            this.CHselectall.AutoSize = true;
            this.CHselectall.Checked = true;
            this.CHselectall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHselectall.Location = new System.Drawing.Point(19, 119);
            this.CHselectall.Name = "CHselectall";
            this.CHselectall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CHselectall.Size = new System.Drawing.Size(90, 18);
            this.CHselectall.TabIndex = 10;
            this.CHselectall.Text = "انتخاب همه";
            this.CHselectall.UseVisualStyleBackColor = true;
            this.CHselectall.CheckedChanged += new System.EventHandler(this.CHselectall_CheckedChanged);
            // 
            // Ncustom
            // 
            this.Ncustom.Enabled = false;
            this.Ncustom.Location = new System.Drawing.Point(16, 36);
            this.Ncustom.Name = "Ncustom";
            this.Ncustom.Size = new System.Drawing.Size(98, 21);
            this.Ncustom.TabIndex = 9;
            // 
            // CHcustom
            // 
            this.CHcustom.AutoSize = true;
            this.CHcustom.Location = new System.Drawing.Point(111, 37);
            this.CHcustom.Name = "CHcustom";
            this.CHcustom.Size = new System.Drawing.Size(169, 18);
            this.CHcustom.TabIndex = 8;
            this.CHcustom.Text = "تعداد روز گذشته دلخواه : ";
            this.CHcustom.UseVisualStyleBackColor = true;
            this.CHcustom.CheckedChanged += new System.EventHandler(this.CHcustom_CheckedChanged);
            // 
            // btnextarct
            // 
            this.btnextarct.Enabled = false;
            this.btnextarct.Location = new System.Drawing.Point(19, 419);
            this.btnextarct.Name = "btnextarct";
            this.btnextarct.Size = new System.Drawing.Size(430, 25);
            this.btnextarct.TabIndex = 6;
            this.btnextarct.Text = "استخراج اسمامی فامیل و آشنایان";
            this.btnextarct.UseVisualStyleBackColor = true;
            this.btnextarct.Click += new System.EventHandler(this.btnextarct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "مرحوم های یافت شده :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAnalise
            // 
            this.btnAnalise.Location = new System.Drawing.Point(19, 79);
            this.btnAnalise.Name = "btnAnalise";
            this.btnAnalise.Size = new System.Drawing.Size(430, 25);
            this.btnAnalise.TabIndex = 3;
            this.btnAnalise.Text = "آنالیز";
            this.btnAnalise.UseVisualStyleBackColor = true;
            this.btnAnalise.Click += new System.EventHandler(this.btnAnalise_Click);
            // 
            // CHyear
            // 
            this.CHyear.AutoSize = true;
            this.CHyear.Checked = true;
            this.CHyear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHyear.Location = new System.Drawing.Point(286, 37);
            this.CHyear.Name = "CHyear";
            this.CHyear.Size = new System.Drawing.Size(50, 18);
            this.CHyear.TabIndex = 2;
            this.CHyear.Text = "سال";
            this.CHyear.UseVisualStyleBackColor = true;
            // 
            // CHforteen
            // 
            this.CHforteen.AutoSize = true;
            this.CHforteen.Checked = true;
            this.CHforteen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHforteen.Location = new System.Drawing.Point(340, 37);
            this.CHforteen.Name = "CHforteen";
            this.CHforteen.Size = new System.Drawing.Size(54, 18);
            this.CHforteen.TabIndex = 1;
            this.CHforteen.Text = "چهلم";
            this.CHforteen.UseVisualStyleBackColor = true;
            // 
            // CHweek
            // 
            this.CHweek.AutoSize = true;
            this.CHweek.Checked = true;
            this.CHweek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHweek.Location = new System.Drawing.Point(400, 36);
            this.CHweek.Name = "CHweek";
            this.CHweek.Size = new System.Drawing.Size(49, 18);
            this.CHweek.TabIndex = 0;
            this.CHweek.Text = "هفته";
            this.CHweek.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 483);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(589, 25);
            this.progressBar1.TabIndex = 7;
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Location = new System.Drawing.Point(12, 447);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(303, 25);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "حذف مورد انتخاب شده";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnStartPrint
            // 
            this.btnStartPrint.Enabled = false;
            this.btnStartPrint.Location = new System.Drawing.Point(607, 483);
            this.btnStartPrint.Name = "btnStartPrint";
            this.btnStartPrint.Size = new System.Drawing.Size(181, 25);
            this.btnStartPrint.TabIndex = 5;
            this.btnStartPrint.Text = "شروع فرایند چاپ";
            this.btnStartPrint.UseVisualStyleBackColor = true;
            this.btnStartPrint.Click += new System.EventHandler(this.btnStartPrint_Click);
            // 
            // SmartPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartPrint);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btndel);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SmartPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چاپ هوشمند";
            this.Load += new System.EventHandler(this.SmartPrint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ncustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnextarct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnAnalise;
        private System.Windows.Forms.CheckBox CHyear;
        private System.Windows.Forms.CheckBox CHforteen;
        private System.Windows.Forms.CheckBox CHweek;
        private System.Windows.Forms.NumericUpDown Ncustom;
        private System.Windows.Forms.CheckBox CHcustom;
        private System.Windows.Forms.Button btnStartPrint;
        private System.Windows.Forms.CheckBox CHselectall;
    }
}