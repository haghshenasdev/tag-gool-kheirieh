using kheirieh.datalayer.Context;
using kheirieh_app_winform.Accounting.anbar;
using kheirieh_app_winform.Accounting.marhoom;
using kheirieh_app_winform.Accounting.person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.dialog
{
    public partial class ChoseDialog : Form
    {
        public ChoseDialog()
        {
            InitializeComponent();
        }

        public string type;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int retunedid;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "anbar":
                    FRMAnbarEditOrAdd frmanbar = new FRMAnbarEditOrAdd();
                    if (frmanbar.ShowDialog() == DialogResult.OK)
                    {
                        retunedid = frmanbar.AffectedId;
                        DialogResult = DialogResult.OK;
                    }
                    break;
                case "person":
                    FRMPersonEditOrAdd frmperson = new FRMPersonEditOrAdd();
                    if (frmperson.ShowDialog() == DialogResult.OK)
                    {
                        retunedid = frmperson.AffectedId;
                        DialogResult = DialogResult.OK;
                    }
                    break;
                case "marhoom":
                    FRMMarhoomEditOrAdd frmmarhoom = new FRMMarhoomEditOrAdd();
                    if (frmmarhoom.ShowDialog() == DialogResult.OK)
                    {
                        retunedid = frmmarhoom.AffectedId;
                        DialogResult = DialogResult.OK;
                    }
                    break;
                default:
                    MessageBox.Show("نوع یافت نشد !");
                    break;
            }
        }

        private void bindgrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                switch (type)
                {
                    case "anbar":
                        dgview.DataSource = db.TajRepository.Get();
                        break;
                    case "person":
                        dgview.DataSource = db.PersonRepository.Get();
                        break;
                    case "marhoom":
                        dgview.DataSource = db.MarhomRepository.Get();
                        break;
                    default:
                        MessageBox.Show("به روز رسانی نشد !");
                        break;
                }
            }
        }

        private void ChoseDialog_Load(object sender, EventArgs e)
        {
            dgview.AutoGenerateColumns = false;

            using (UnitOfWork db = new UnitOfWork())
            {
                switch (type)
                {
                    case "anbar":
                        this.Text = "انتخاب نوع";
                        AddColumn("نوع", "typename");
                        AddColumn("مبلغ", "amount");
                        AddColumn("تعداد", "count");
                        dgview.DataSource = db.TajRepository.Get();
                        break;
                    case "person":
                        this.Text = "انتخاب اشخص";
                        AddColumn("نام", "name");
                        AddColumn("تلفن", "phone");
                        AddColumn("آدرس", "adres");
                        dgview.DataSource = db.PersonRepository.Get();
                        break;
                    case "marhoom":
                        this.Text = "انتخاب مرحوم";
                        AddColumn("نام", "name");
                        AddColumn("تاریخ وفات", "date");
                        dgview.DataSource = db.MarhomRepository.Get();
                        break;
                    default:
                        MessageBox.Show("فرم باز نشد !");
                        this.Close();
                        break;
                }
            }
        }

        private void AddColumn(string header, string dataname)
        {
            dgview.Columns.Add(dataname, header);
            dgview.Columns[dataname].DataPropertyName = dataname;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (dgview.CurrentRow != null)
            {
                retunedid = (int)dgview.CurrentRow.Cells[0].Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("لطفا یک مورد را از لیست انتخاب کنید");
            }
        }
    }
}
