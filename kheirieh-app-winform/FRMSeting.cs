using kheirieh.datalayer.Context;
using kheirieh.datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace kheirieh_app_winform
{
    public partial class FRMSeting : Form
    {
        public FRMSeting()
        {
            InitializeComponent();
        }

        private void DefualtTarhTXT_Enter(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
        }

        private void DefualtTypeTXT_Enter(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TarhRand_CheckedChanged(object sender, EventArgs e)
        {
            DefualtTarhTXT.Text = "";
            if (TarhRand.Checked)
            {
                tarhid = 0;
            }
            else
            {
                tarhid = null;
            }

        }

        int LimitTable;
        private void FRMSeting_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                LimitTable = Int32.Parse(db.setingappRepository.GetByID(3).value.ToString());
                dgtarhs.AutoGenerateColumns = false;
                dgtajtype.AutoGenerateColumns = false;
                dgtarhs.DataSource = db.TemplateRepository.Get(null, 15);
                dgtajtype.DataSource = db.TajRepository.Get(null, 15);

                var seting = db.setingappRepository.GetByID(1).value;
                if (GetSeting.getdefualttarhVal(db) == 0)
                {
                    TarhRand.Checked = true;
                }
                else
                {
                    DefualtTarhTXT.Text = GetSeting.getdefualttarh(db).name.ToString();
                }

                var defualttype = db.TajRepository.GetByID(GetSeting.getDefualtTypeId(db));
                DefualtTypeTXT.Text = defualttype.typename.ToString();

                txtpath.Text = GetSeting.getDefulttemplatePtah(db);

                nLimittable.Value = GetSeting.getLimitTables(db);
            }
        }

        int? typeid;
        private void dgtajtype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DefualtTypeTXT.Text = dgtajtype.CurrentRow.Cells[1].Value.ToString();
            typeid = Int32.Parse(dgtajtype.CurrentRow.Cells[0].Value.ToString());
        }

        int? tarhid;
        private void dgtarhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TarhRand.Checked = false;
            DefualtTarhTXT.Text = dgtarhs.CurrentRow.Cells[1].Value.ToString();
            tarhid = Int32.Parse(dgtarhs.CurrentRow.Cells[0].Value.ToString());
        }

        private void tarhsearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (tarhsearch.Text != "")
                {
                    dgtarhs.DataSource = db.NGTemplateRepository.GetByFilterName(tarhsearch.Text);
                }
                else
                {
                    dgtarhs.DataSource = db.TemplateRepository.Get(null, LimitTable);
                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (UnitOfWork db = new UnitOfWork())
            {
                if (tarhid != null)
                {
                    db.setingappRepository.Update(new kheirieh.datalayer.setingapp()
                    {
                        id = 1,
                        name = "defualt_tarh",
                        value = tarhid.ToString()
                    });
                }

                if (typeid != null)
                {
                    db.setingappRepository.Update(new kheirieh.datalayer.setingapp()
                    {
                        id = 2,
                        name = "defualt_type",
                        value = typeid.ToString()
                    });
                }
                string defpath = GetSeting.getDefulttemplatePtah();
                if (txtpath.Text != defpath)
                {
                    if (defpath == "templates")
                    {
                        defpath = Application.StartupPath + "\\templates";
                    }
                    if (MessageBox.Show("آیا می خواهید تمام طرح ها ی موجود به مسیری که تازه انتخاب کرده اید منتقل شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!Directory.Exists(txtpath.Text))
                        {
                            Directory.CreateDirectory(txtpath.Text);
                        }
                        var directories = Directory.GetDirectories(defpath);
                        wait fw = new wait();
                        fw.Show();
                        foreach (var item in directories)
                        {
                            Directory.Move(item, txtpath.Text + "\\" + Path.GetFileName(item));
                        }
                        fw.Close();
                    }

                    db.setingappRepository.Update(new setingapp()
                    {
                        id = 4,
                        name = "templatepath",
                        value = txtpath.Text
                    });
                }
                db.setingappRepository.Update(new setingapp()
                {
                    id = 3,
                    name = "limit_tables",
                    value = nLimittable.Value.ToString()
                });
                db.Save();
            }
            MessageBox.Show("تنظیمات ذخیره شد");
            DialogResult = DialogResult.OK;
            //}
            //catch (Exception)
            //{
            //MessageBox.Show("تنظیمات ذخیره نشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void typesearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (typesearch.Text != "")
                {
                    dgtajtype.DataSource = db.NGTajTypeRepository.GetByFilterName(typesearch.Text);
                }
                else
                {
                    dgtajtype.DataSource = db.TajRepository.Get(null, LimitTable);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void DefualtTypeTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbrose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();

            if (df.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = df.SelectedPath;
            }

        }
    }
}
