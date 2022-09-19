namespace kheirieh_app_winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgmarhom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgperson = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgtajtype = new System.Windows.Forms.DataGridView();
            this.idtaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgtarhs = new System.Windows.Forms.DataGridView();
            this.idtarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametarh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ismarhomeh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.چاپهوشمندToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سفارشاتآنلاینToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حسابداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستمرحومهامراسماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اشخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کرایههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarhs = new System.Windows.Forms.ToolStripMenuItem();
            this.طراحیطرحجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نصببستههایگرافیکیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnchap = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.tarhpic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttype = new System.Windows.Forms.TextBox();
            this.labeltrah = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nAmount = new System.Windows.Forms.NumericUpDown();
            this.nCount = new System.Windows.Forms.NumericUpDown();
            this.ispardakht = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPrintedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnmultiselect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmarhom)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgperson)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtajtype)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 456);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgmarhom);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مرحوم";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgmarhom
            // 
            this.dgmarhom.AllowUserToAddRows = false;
            this.dgmarhom.AllowUserToDeleteRows = false;
            this.dgmarhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgmarhom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgmarhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmarhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgmarhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgmarhom.Location = new System.Drawing.Point(3, 3);
            this.dgmarhom.Name = "dgmarhom";
            this.dgmarhom.ReadOnly = true;
            this.dgmarhom.Size = new System.Drawing.Size(394, 423);
            this.dgmarhom.TabIndex = 0;
            this.dgmarhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmarhom_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgperson);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "طرف";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgperson
            // 
            this.dgperson.AllowUserToAddRows = false;
            this.dgperson.AllowUserToDeleteRows = false;
            this.dgperson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgperson.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgperson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgperson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgperson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgperson.Location = new System.Drawing.Point(3, 3);
            this.dgperson.Name = "dgperson";
            this.dgperson.ReadOnly = true;
            this.dgperson.Size = new System.Drawing.Size(394, 423);
            this.dgperson.TabIndex = 1;
            this.dgperson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgperson_CellClick);
            this.dgperson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgperson_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgtajtype);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(400, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "نوع تاج گل";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.dgtajtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtajtype.Location = new System.Drawing.Point(3, 3);
            this.dgtajtype.Name = "dgtajtype";
            this.dgtajtype.ReadOnly = true;
            this.dgtajtype.Size = new System.Drawing.Size(394, 423);
            this.dgtajtype.TabIndex = 2;
            this.dgtajtype.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtajtype_CellClick);
            this.dgtajtype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtajtype_CellContentClick);
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
            this.count.HeaderText = "تعداد در انبار";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgtarhs);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(400, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "طرح (انتخاب تصادفی)";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.dgtarhs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtarhs.Location = new System.Drawing.Point(3, 3);
            this.dgtarhs.Name = "dgtarhs";
            this.dgtarhs.ReadOnly = true;
            this.dgtarhs.Size = new System.Drawing.Size(394, 423);
            this.dgtarhs.TabIndex = 3;
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
            // mtxt
            // 
            this.mtxt.Location = new System.Drawing.Point(560, 289);
            this.mtxt.Name = "mtxt";
            this.mtxt.Size = new System.Drawing.Size(240, 21);
            this.mtxt.TabIndex = 1;
            this.mtxt.TextChanged += new System.EventHandler(this.mtxt_TextChanged);
            this.mtxt.Enter += new System.EventHandler(this.mtxt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام مرحوم :";
            // 
            // ismarhomeh
            // 
            this.ismarhomeh.AutoSize = true;
            this.ismarhomeh.Location = new System.Drawing.Point(487, 291);
            this.ismarhomeh.Name = "ismarhomeh";
            this.ismarhomeh.Size = new System.Drawing.Size(67, 18);
            this.ismarhomeh.TabIndex = 3;
            this.ismarhomeh.Text = "مرحومه";
            this.ismarhomeh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "از طرف :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ttxt
            // 
            this.ttxt.Location = new System.Drawing.Point(560, 334);
            this.ttxt.Name = "ttxt";
            this.ttxt.Size = new System.Drawing.Size(240, 21);
            this.ttxt.TabIndex = 4;
            this.ttxt.Click += new System.EventHandler(this.ttxt_Click);
            this.ttxt.TextChanged += new System.EventHandler(this.ttxt_TextChanged);
            this.ttxt.Enter += new System.EventHandler(this.ttxt_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.چاپهوشمندToolStripMenuItem,
            this.سفارشاتآنلاینToolStripMenuItem,
            this.حسابداریToolStripMenuItem,
            this.تنظیماتToolStripMenuItem,
            this.tarhs,
            this.دربارهToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // چاپهوشمندToolStripMenuItem
            // 
            this.چاپهوشمندToolStripMenuItem.Name = "چاپهوشمندToolStripMenuItem";
            this.چاپهوشمندToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.چاپهوشمندToolStripMenuItem.Text = "چاپ هوشمند";
            this.چاپهوشمندToolStripMenuItem.Click += new System.EventHandler(this.چاپهوشمندToolStripMenuItem_Click);
            // 
            // سفارشاتآنلاینToolStripMenuItem
            // 
            this.سفارشاتآنلاینToolStripMenuItem.Name = "سفارشاتآنلاینToolStripMenuItem";
            this.سفارشاتآنلاینToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.سفارشاتآنلاینToolStripMenuItem.Text = "سفارشات آنلاین";
            this.سفارشاتآنلاینToolStripMenuItem.Click += new System.EventHandler(this.سفارشاتآنلاینToolStripMenuItem_Click);
            // 
            // حسابداریToolStripMenuItem
            // 
            this.حسابداریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشاتToolStripMenuItem,
            this.لیستمرحومهامراسماتToolStripMenuItem,
            this.اشخاصToolStripMenuItem,
            this.کرایههاToolStripMenuItem,
            this.انبارداریToolStripMenuItem});
            this.حسابداریToolStripMenuItem.Name = "حسابداریToolStripMenuItem";
            this.حسابداریToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.حسابداریToolStripMenuItem.Text = "حساب داری";
            this.حسابداریToolStripMenuItem.Click += new System.EventHandler(this.حسابداریToolStripMenuItem_Click);
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            this.گزارشاتToolStripMenuItem.Click += new System.EventHandler(this.گزارشاتToolStripMenuItem_Click);
            // 
            // لیستمرحومهامراسماتToolStripMenuItem
            // 
            this.لیستمرحومهامراسماتToolStripMenuItem.Name = "لیستمرحومهامراسماتToolStripMenuItem";
            this.لیستمرحومهامراسماتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.لیستمرحومهامراسماتToolStripMenuItem.Text = "مرحوم ها (مراسمات)";
            this.لیستمرحومهامراسماتToolStripMenuItem.Click += new System.EventHandler(this.لیستمرحومهامراسماتToolStripMenuItem_Click);
            // 
            // اشخاصToolStripMenuItem
            // 
            this.اشخاصToolStripMenuItem.Name = "اشخاصToolStripMenuItem";
            this.اشخاصToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.اشخاصToolStripMenuItem.Text = "اشخاص";
            this.اشخاصToolStripMenuItem.Click += new System.EventHandler(this.اشخاصToolStripMenuItem_Click);
            // 
            // کرایههاToolStripMenuItem
            // 
            this.کرایههاToolStripMenuItem.Name = "کرایههاToolStripMenuItem";
            this.کرایههاToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.کرایههاToolStripMenuItem.Text = "کرایه ها";
            this.کرایههاToolStripMenuItem.Click += new System.EventHandler(this.کرایههاToolStripMenuItem_Click);
            // 
            // انبارداریToolStripMenuItem
            // 
            this.انبارداریToolStripMenuItem.Name = "انبارداریToolStripMenuItem";
            this.انبارداریToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.انبارداریToolStripMenuItem.Text = "انبار داری";
            this.انبارداریToolStripMenuItem.Click += new System.EventHandler(this.انبارداریToolStripMenuItem_Click);
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            this.تنظیماتToolStripMenuItem.Click += new System.EventHandler(this.تنظیماتToolStripMenuItem_Click);
            // 
            // tarhs
            // 
            this.tarhs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طراحیطرحجدیدToolStripMenuItem,
            this.نصببستههایگرافیکیToolStripMenuItem});
            this.tarhs.Name = "tarhs";
            this.tarhs.Size = new System.Drawing.Size(42, 20);
            this.tarhs.Text = "طرح";
            // 
            // طراحیطرحجدیدToolStripMenuItem
            // 
            this.طراحیطرحجدیدToolStripMenuItem.Name = "طراحیطرحجدیدToolStripMenuItem";
            this.طراحیطرحجدیدToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.طراحیطرحجدیدToolStripMenuItem.Text = "طراحی طرح جدید";
            this.طراحیطرحجدیدToolStripMenuItem.Click += new System.EventHandler(this.طراحیطرحجدیدToolStripMenuItem_Click);
            // 
            // نصببستههایگرافیکیToolStripMenuItem
            // 
            this.نصببستههایگرافیکیToolStripMenuItem.Name = "نصببستههایگرافیکیToolStripMenuItem";
            this.نصببستههایگرافیکیToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.نصببستههایگرافیکیToolStripMenuItem.Text = "مدیریت طرح ها و نصب بسته گرافیکی";
            this.نصببستههایگرافیکیToolStripMenuItem.Click += new System.EventHandler(this.نصببستههایگرافیکیToolStripMenuItem_Click);
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.دربارهToolStripMenuItem.Text = "درباره";
            this.دربارهToolStripMenuItem.Click += new System.EventHandler(this.دربارهToolStripMenuItem_Click);
            // 
            // btnchap
            // 
            this.btnchap.Location = new System.Drawing.Point(487, 467);
            this.btnchap.Name = "btnchap";
            this.btnchap.Size = new System.Drawing.Size(157, 23);
            this.btnchap.TabIndex = 9;
            this.btnchap.Text = "چاپ";
            this.btnchap.UseVisualStyleBackColor = true;
            this.btnchap.Click += new System.EventHandler(this.btnchap_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(650, 467);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(150, 23);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "نمایش و ویرایش";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarhpic
            // 
            this.tarhpic.InitialImage = global::kheirieh_app_winform.Properties.Resources.loding2;
            this.tarhpic.Location = new System.Drawing.Point(459, 79);
            this.tarhpic.Name = "tarhpic";
            this.tarhpic.Size = new System.Drawing.Size(415, 180);
            this.tarhpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tarhpic.TabIndex = 11;
            this.tarhpic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "نوع :";
            // 
            // ttype
            // 
            this.ttype.Location = new System.Drawing.Point(487, 378);
            this.ttype.Name = "ttype";
            this.ttype.ReadOnly = true;
            this.ttype.Size = new System.Drawing.Size(313, 21);
            this.ttype.TabIndex = 12;
            // 
            // labeltrah
            // 
            this.labeltrah.AutoSize = true;
            this.labeltrah.Location = new System.Drawing.Point(468, 41);
            this.labeltrah.Name = "labeltrah";
            this.labeltrah.Size = new System.Drawing.Size(0, 14);
            this.labeltrah.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "قیمت :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "تعداد :";
            // 
            // nAmount
            // 
            this.nAmount.Location = new System.Drawing.Point(692, 422);
            this.nAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nAmount.Name = "nAmount";
            this.nAmount.Size = new System.Drawing.Size(108, 21);
            this.nAmount.TabIndex = 19;
            // 
            // nCount
            // 
            this.nCount.Location = new System.Drawing.Point(487, 422);
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(67, 21);
            this.nCount.TabIndex = 20;
            this.nCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ispardakht
            // 
            this.ispardakht.AutoSize = true;
            this.ispardakht.Checked = true;
            this.ispardakht.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ispardakht.Location = new System.Drawing.Point(620, 424);
            this.ispardakht.Name = "ispardakht";
            this.ispardakht.Size = new System.Drawing.Size(66, 18);
            this.ispardakht.TabIndex = 21;
            this.ispardakht.Text = "دریافت";
            this.ispardakht.UseVisualStyleBackColor = true;
            this.ispardakht.CheckedChanged += new System.EventHandler(this.ispayed_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "طرح انتخاب شده :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripPrintedCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel4.Text = "تاریخ سیستم :";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "تاریخ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel2.Text = "تعداد طرح های چاپ شده : ";
            // 
            // toolStripPrintedCount
            // 
            this.toolStripPrintedCount.Name = "toolStripPrintedCount";
            this.toolStripPrintedCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripPrintedCount.Text = "0";
            // 
            // btnmultiselect
            // 
            this.btnmultiselect.Location = new System.Drawing.Point(487, 334);
            this.btnmultiselect.Name = "btnmultiselect";
            this.btnmultiselect.Size = new System.Drawing.Size(67, 23);
            this.btnmultiselect.TabIndex = 24;
            this.btnmultiselect.Text = "چند تایی";
            this.btnmultiselect.UseVisualStyleBackColor = true;
            this.btnmultiselect.Click += new System.EventHandler(this.btnmultiselect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 539);
            this.Controls.Add(this.btnmultiselect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ispardakht);
            this.Controls.Add(this.nCount);
            this.Controls.Add(this.nAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labeltrah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.tarhpic);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnchap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttxt);
            this.Controls.Add(this.ismarhomeh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("A Iranian Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار خیریه";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmarhom)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgperson)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtajtype)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtarhs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarhpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox mtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ismarhomeh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
        private System.Windows.Forms.Button btnchap;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ToolStripMenuItem tarhs;
        private System.Windows.Forms.DataGridView dgmarhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView dgperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox tarhpic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Label labeltrah;
        private System.Windows.Forms.DataGridView dgtajtype;
        private System.Windows.Forms.DataGridView dgtarhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametarh;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nAmount;
        private System.Windows.Forms.NumericUpDown nCount;
        private System.Windows.Forms.CheckBox ispardakht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem حسابداریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستمرحومهامراسماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اشخاصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کرایههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طراحیطرحجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نصببستههایگرافیکیToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem چاپهوشمندToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPrintedCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem انبارداریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سفارشاتآنلاینToolStripMenuItem;
        private System.Windows.Forms.Button btnmultiselect;
    }
}

