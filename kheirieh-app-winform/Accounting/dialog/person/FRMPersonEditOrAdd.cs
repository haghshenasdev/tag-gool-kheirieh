using kheirieh.datalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.person
{
    public partial class FRMPersonEditOrAdd : Form
    {
        public FRMPersonEditOrAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int id = 0;

        private void FRMPersonEditOrAdd_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var data = db.PersonRepository.GetByID(id);
                    Txtname.Text = data.name;
                    TxtAdres.Text = data.adres;
                    TxtPhone.Text = data.phone;
                }
            }
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
                    var persondata = new kheirieh.datalayer.person()
                    {
                        name = Txtname.Text,
                        phone = TxtPhone.Text,
                        adres = TxtAdres.Text
                    };

                    if (id != 0)
                    {
                        persondata.id = id;
                        db.PersonRepository.Update(persondata);
                    }
                    else
                    {
                        db.PersonRepository.Insert(persondata);
                    }

                    db.Save();
                    AffectedId = persondata.id;
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
