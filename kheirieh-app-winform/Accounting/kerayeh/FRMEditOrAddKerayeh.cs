using kheirieh.datalayer.Context;
using kheirieh.utility.convertor;
using kheirieh_app_winform.Accounting.dialog;
using kheirieh_app_winform.Accounting.dialog.tarh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.kerayeh
{
    public partial class FRMEditOrAddKerayeh : Form
    {
        public FRMEditOrAddKerayeh()
        {
            InitializeComponent();
        }

        public int id = 0;
        int mid;
        int? tarhid = null;
        int? typeid;
        int? usertarafid;

        private void FRMEditOrAddKerayeh_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Text = "ویرایش کرایه";
                btnsave.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var datak = db.KerayehRepository.GetByID(id);
                    mid = datak.marhom;
                    txtmName.Text = getDataM(db, datak.marhom);

                    if (datak.type != null)
                    {
                        typeid = datak.type;
                        txttype.Text = getDataT(db, datak.type);
                    }

                    if (datak.usertraf != null)
                    {
                        usertarafid = datak.usertraf;
                        txttName.Text = getDataP(db, datak.usertraf);
                    }

                    if (datak.tarh != null)
                        txttarh.Text = getDataTarh(db, (int)datak.tarh);

                    dateTimePicker1.Value = datak.date;
                    dateshow.Text = dateTimePicker1.Value.ToShamsi();
                    nAmount.Value = (decimal)datak.amountpay;
                    nCount.Value = (decimal)datak.count;
                    ispardakht.Checked = (datak.ispardakht != null && datak.ispardakht == 1) ? true : false;
                }
            }
        }

        private string getDataTarh(UnitOfWork db, int? id)
        {
            return db.TemplateRepository.GetByID(id).name;
        }

        private string getDataM(UnitOfWork db, int id)
        {
            return db.MarhomRepository.GetByID(id).name;
        }

        private string getDataP(UnitOfWork db, int? id)
        {
            return db.PersonRepository.GetByID(id).name;
        }

        private string getDataT(UnitOfWork db, int? id)
        {
            return db.TajRepository.GetByID(id).typename;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateshow.Text = dateTimePicker1.Value.ToShamsi();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var kerdata = new kheirieh.datalayer.kerayeh()
                {
                    amountpay = (int)nAmount.Value,
                    count = (int)nCount.Value,
                    date = dateTimePicker1.Value,
                    ispardakht = (ispardakht.Checked) ? 1 : 0,
                    marhom = mid,
                    usertraf = usertarafid,
                    tarh = tarhid,
                    type = typeid
                };

                if (id != 0)
                {
                    kerdata.id = id;
                    db.KerayehRepository.Update(kerdata);
                }
                else
                {
                    db.KerayehRepository.Insert(kerdata);
                }
                db.Save();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnchoseType_Click(object sender, EventArgs e)
        {
            ChoseDialog cd = new ChoseDialog();
            cd.type = "anbar";
            if (cd.ShowDialog() == DialogResult.OK)
            {
                typeid = cd.retunedid;
                using (UnitOfWork db = new UnitOfWork())
                {
                    txttype.Text = getDataT(db, typeid);
                    nAmount.Value = db.TajRepository.GetByID(typeid).amount;
                }
            }
        }

        private void btnChoseMarhoom_Click(object sender, EventArgs e)
        {
            ChoseDialog cd = new ChoseDialog();
            cd.type = "marhoom";
            if (cd.ShowDialog() == DialogResult.OK)
            {
                mid = cd.retunedid;
                using (UnitOfWork db = new UnitOfWork())
                {
                    txtmName.Text = getDataM(db, mid);
                }
            }
        }

        private void btnChosePerson_Click(object sender, EventArgs e)
        {
            ChoseDialog cd = new ChoseDialog();
            cd.type = "person";
            if (cd.ShowDialog() == DialogResult.OK)
            {
                usertarafid = cd.retunedid;
                using (UnitOfWork db = new UnitOfWork())
                {
                    txttName.Text = getDataP(db, usertarafid);
                }
            }
        }

        private void btnChoseTarh_Click(object sender, EventArgs e)
        {
            FRMChoseTarh CT = new FRMChoseTarh();
            if (tarhid != null) CT.retunedid = tarhid;

            if (CT.ShowDialog() == DialogResult.OK)
            {
                tarhid = CT.retunedid;
                using (UnitOfWork db = new UnitOfWork())
                {
                    txttarh.Text = getDataTarh(db, (int)tarhid);
                }
            }
        }

        private void btnDelTarh_Click(object sender, EventArgs e)
        {
            txttarh.Text = "";
            tarhid = null;
        }
    }
}
