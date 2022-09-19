using kheirieh.datalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.anbar
{
    public partial class FRMAnbarEditOrAdd : Form
    {
        public FRMAnbarEditOrAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void FRMAnbarEditOrAdd_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Text = "ویرایش نوع";
                btnSave.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var data = db.TajRepository.GetByID(id);
                    txtTypename.Text = data.typename;
                    txtDescription.Text = data.description;
                    nmAmount.Value = data.amount;
                    nmCount.Value = (data.count != null) ? (int)data.count : 0;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int AffectedId;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var taj = new kheirieh.datalayer.taj()
                    {
                        typename = txtTypename.Text,
                        description = txtDescription.Text,
                        amount = (int)nmAmount.Value,
                        count = (int)nmCount.Value,
                    };

                    if (id != 0)
                    {
                        taj.id = id;
                        db.TajRepository.Update(taj);
                    }
                    else
                    {
                        db.TajRepository.Insert(taj);
                    }

                    db.Save();
                    AffectedId = taj.id;
                }
                MessageBox.Show("عملیات با موفقیت انجام شد .");
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("عملیات با شکست مواجه شد .", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
