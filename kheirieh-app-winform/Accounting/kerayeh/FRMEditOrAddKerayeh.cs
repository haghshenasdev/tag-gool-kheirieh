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

namespace kheirieh_app_winform.Accounting.kerayeh
{
    public partial class FRMEditOrAddKerayeh : Form
    {
        public FRMEditOrAddKerayeh()
        {
            InitializeComponent();
        }
        public int id;
        private void FRMEditOrAddKerayeh_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var datak = db.NGKerayehRepository.joinbyid(id);
                txtmName.Text = datak.marhom;
                dateTimePicker1.Value = datak.date;
                dateshow.Text = dateTimePicker1.Value.ToShamsi();
                txttype.Text = datak.type;
                txttName.Text = datak.usertraf;
                nAmount.Value = (decimal)datak.amountpay;
                nCount.Value = (decimal)datak.count;
                ispardakht.Checked = (datak.ispardakht != null && datak.ispardakht == 1) ? true : false;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateshow.Text = dateTimePicker1.Value.ToShamsi();
        }

        int? mid;
        int? tarhid;
        int? typeid;
        int? usertarafid;
        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در بروز رسانی های بعدی فعال می شود");
            //if (mid == null)
            //{
            //    using (UnitOfWork db = new UnitOfWork())
            //    {
            //        //------------------------
            //        var dm = db.MarhomRepository.Get(m => m.name == txtmName.Text).FirstOrDefault();
            //        if (dm != null)
            //        {
            //            mid = dm.id;
            //        }
            //        else
            //        {
            //            if (MessageBox.Show("آیا مایل به ایجاد مرحوم جدید هستید ؟", "مرحومی با این نام یافت نشد!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //            {
            //                using (UnitOfWork db2 = new UnitOfWork())
            //                {
            //                    db2.MarhomRepository.Insert(new kheirieh.datalayer.marhoom
            //                    {
            //                        name = txtmName.Text,
            //                        date = DateTime.Now
            //                    });
            //                    db2.Save();
            //                }
            //                mid = db.MarhomRepository.Get().Last().id;
            //            }
            //            else return;
            //        }
            //        //------------------------
            //    }
            //}
            //if (usertarafid == null)
            //{
            //    using (UnitOfWork db = new UnitOfWork())
            //    {
            //        var dtaraf = db.PersonRepository.Get(m => m.name == txttName.Text).FirstOrDefault();
            //        if (dtaraf != null)
            //        {
            //            usertarafid = dtaraf.id;
            //        }
            //        else
            //        {
            //            if (MessageBox.Show("آیا مایل به ایجاد طرف جدید هستید ؟", "طرفی با این نام یافت نشد!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //            {
            //                using (UnitOfWork db2 = new UnitOfWork())
            //                {
            //                    db2.PersonRepository.Insert(new kheirieh.datalayer.person
            //                    {
            //                        name = txttName.Text,
            //                    });
            //                    db2.Save();
            //                }
            //                usertarafid = db.PersonRepository.Get().Last().id;
            //            }
            //            else return;
            //        }
            //        //------------------------
            //    }
            //}
            //using (UnitOfWork db = new UnitOfWork())
            //{
            //    db.KerayehRepository.Update(new kheirieh.datalayer.kerayeh()
            //    {
            //        id = id,
            //        ispardakht = (ispardakht.Checked) ? 1 : 0,
            //        amountpay = (int)nAmount.Value,
            //        count = (int)nCount.Value,
            //        date = dateTimePicker1.Value,
            //        marhom = (int)mid,
            //        tarh = tarhid,
            //        type = (int)typeid,
            //        usertraf = (int)usertarafid
            //    });
            //    db.Save();
            //}
        }
    }
}
