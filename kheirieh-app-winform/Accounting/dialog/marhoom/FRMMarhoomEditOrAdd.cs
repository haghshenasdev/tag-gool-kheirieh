using kheirieh.datalayer.Context;
using kheirieh.utility.convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.marhoom
{
    public partial class FRMMarhoomEditOrAdd : Form
    {
        public FRMMarhoomEditOrAdd()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateshow.Text = dateTimePicker1.Value.ToShamsi();
        }

        public int id = 0;

        private void FRMMarhoomEditOrAdd_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Text = "ویرایش مرحوم";
                btnSave.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var data = db.MarhomRepository.GetByID(id);
                    Txtname.Text = data.name;
                    dateTimePicker1.Value = data.date;
                }
            }

            dateTimePicker1_ValueChanged(null, null);
        }

        public int AffectedId;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Txtname.Text.Trim() == "")
            {
                MessageBox.Show("نام نمی تواند خالی باشد!");
                return;
            }

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var marhoomdata = new kheirieh.datalayer.marhoom()
                    {
                        name = Txtname.Text,
                        date = dateTimePicker1.Value
                    };

                    if (id != 0)
                    {
                        marhoomdata.id = id;
                        db.MarhomRepository.Update(marhoomdata);
                    }
                    else
                    {
                        db.MarhomRepository.Insert(marhoomdata);
                    }

                    db.Save();
                    AffectedId = marhoomdata.id;
                }

                MessageBox.Show("عملیات با موفقیت انجام شد .");
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("عملیات با شکست مواجه شد .", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
