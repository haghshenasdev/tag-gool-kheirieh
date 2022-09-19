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

namespace kheirieh_app_winform.Accounting
{
    public partial class FRMManageRows : Form
    {
        public FRMManageRows()
        {
            InitializeComponent();
        }

        public string type;

        private void FRMManageRows_Load(object sender, EventArgs e)
        {
            dgview.AutoGenerateColumns = false;

            using (UnitOfWork db = new UnitOfWork())
            {
                switch (type)
                {
                    case "anbar":
                        this.Text = "مدیریت انبار و نوع";
                        AddColumn("نوع", "typename");
                        AddColumn("مبلغ", "amount");
                        AddColumn("تعداد", "count");
                        dgview.DataSource = db.TajRepository.Get();
                        break;
                    case "person":
                        this.Text = "مدیریت اشخاص";
                        AddColumn("نام", "name");
                        AddColumn("تلفن", "phone");
                        AddColumn("آدرس", "adres");
                        dgview.DataSource = db.PersonRepository.Get();
                        break;
                    case "marhoom":
                        this.Text = "مدیریت مرحوم ها";
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

        private void bindgrid_Click(object sender, EventArgs e)
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

        private void del_Click(object sender, EventArgs e)
        {
            if (dgview.CurrentRow != null)
            {
                int id = (int)dgview.CurrentRow.Cells[0].Value;
                if (MessageBox.Show("آیا مایل به حذف مورد انتخاب شده هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //try
                    //{
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        switch (type)
                        {
                            case "anbar":
                                db.TajRepository.Delete(id);
                                break;
                            case "person":
                                db.PersonRepository.Delete(id);
                                break;
                            case "marhoom":
                                db.MarhomRepository.Delete(id);
                                break;
                            default:
                                MessageBox.Show("نوع یافت نشد !");
                                break;
                        }
                        db.Save();
                    }

                    bindgrid_Click(null, null);
                    //}
                    //catch (Exception)
                    //{

                    //    MessageBox.Show("مورد انتخاب شده حذف نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                }
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dgview.CurrentRow != null)
            {
                int id = (int)dgview.CurrentRow.Cells[0].Value;
                switch (type)
                {
                    case "anbar":
                        FRMAnbarEditOrAdd frmanbar = new FRMAnbarEditOrAdd();
                        frmanbar.id = id;
                        if (frmanbar.ShowDialog() == DialogResult.OK)
                        {
                            bindgrid_Click(null, null);
                        }
                        break;
                    case "person":
                        FRMPersonEditOrAdd frmperson = new FRMPersonEditOrAdd();
                        frmperson.id = id;
                        if (frmperson.ShowDialog() == DialogResult.OK)
                        {
                            bindgrid_Click(null, null);
                        }
                        break;
                    case "marhoom":
                        FRMMarhoomEditOrAdd frmmarhoom = new FRMMarhoomEditOrAdd();
                        frmmarhoom.id = id;
                        if (frmmarhoom.ShowDialog() == DialogResult.OK)
                        {
                            bindgrid_Click(null, null);
                        }
                        break;
                    default:
                        MessageBox.Show("نوع یافت نشد !");
                        break;
                }
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "anbar":
                    FRMAnbarEditOrAdd frmanbar = new FRMAnbarEditOrAdd();
                    if (frmanbar.ShowDialog() == DialogResult.OK)
                    {
                        bindgrid_Click(null, null);
                    }
                    break;
                case "person":
                    FRMPersonEditOrAdd frmperson = new FRMPersonEditOrAdd();
                    if (frmperson.ShowDialog() == DialogResult.OK)
                    {
                        bindgrid_Click(null, null);
                    }
                    break;
                case "marhoom":
                    FRMMarhoomEditOrAdd frmmarhoom = new FRMMarhoomEditOrAdd();
                    if (frmmarhoom.ShowDialog() == DialogResult.OK)
                    {
                        bindgrid_Click(null, null);
                    }
                    break;
                default:
                    MessageBox.Show("نوع یافت نشد !");
                    break;
            }
        }

        private void dgview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_Click(null, null);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    switch (type)
                    {
                        case "anbar":
                            dgview.DataSource = db.TajRepository.Get(
                                    i => i.typename.Contains(txtsearch.Text) || i.amount.ToString().Contains(txtsearch.Text)
                                );
                            break;
                        case "person":
                            dgview.DataSource = db.PersonRepository.Get(
                                    i => i.name.Contains(txtsearch.Text) || i.phone.Contains(txtsearch.Text)
                                );
                            break;
                        case "marhoom":
                            dgview.DataSource = db.MarhomRepository.Get(
                                    i => i.name.Contains(txtsearch.Text)
                                );
                            break;
                        default:
                            MessageBox.Show("به روز رسانی نشد !");
                            break;
                    }
                }
            }
            else
            {
                bindgrid_Click(null, null);
            }
        }
    }
}
