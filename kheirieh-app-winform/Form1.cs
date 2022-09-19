using kheirieh.graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kheirieh.utility;
using kheirieh.datalayer.Context;
using kheirieh_app_winform.Properties;
using kheirieh.datalayer;
using kheirieh_app_winform.Accounting;

namespace kheirieh_app_winform
{
    public partial class Form1 : Form
    {
        //limit tables
        int LimitTables;

        string tarhpth = null;

        TextData marhoomtxt;
        TextData aztarftxt;

        int? tid;
        int? mid;
        int? tarhid;
        int? typeid;
        string fd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //insetaliton splash screen
            FRMwait fRMwait = new FRMwait();
            fRMwait.BackgroundImageLayout = ImageLayout.Zoom;
            fRMwait.BackgroundImage = Resources.splashscreen;
            fRMwait.Show();
            //-------------------------



            using (UnitOfWork db = new UnitOfWork())
            {
                // inestalition databases
                LimitTables = GetSeting.getLimitTables(db);
                dgmarhom.AutoGenerateColumns = false;
                dgmarhom.DataSource = db.MarhomRepository.Get(null, LimitTables);
                //-----------------------

                //get tarh
                try
                {
                    template tarh = GetSeting.getdefualttarh(db);
                    insertTarh(tarh.path, tarh.id, tarh.name);
                }
                catch (Exception)
                {
                    MessageBox.Show("خطا در بارگزاری در طرح پیش فرض !");
                }
                //--------

                toolStripPrintedCount.Text = db.KerayehRepository.CountOfData().ToString();
                toolStripStatusLabel1.Text = DateTime.Now.ToString();

                // get defualt type
                try
                {
                    var type = db.TajRepository.GetByID(GetSeting.getDefualtTypeId(db));

                    typeid = type.id;
                    ttype.Text = type.typename;
                    nAmount.Value = type.amount;
                }
                catch (Exception)
                {
                    MessageBox.Show("خطا در بارگزاری نوع تاج گل پیش فرض");
                }
                //-------------------
            }


            // exit splash screen
            fRMwait.Close();
            //-------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mtxt.Text != "" && ttxt.Text != "")
            {
                if (tarhpth != null)
                {
                    FRMDesigningshow fshow = new FRMDesigningshow();
                    fshow.img = get_tarh(tarhpth);
                    fshow.marhoomtxt = marhoomtxt;
                    fshow.aztarftxt = aztarftxt;
                    fshow.tarhp = tarhpth;
                    fshow.tid = tid;
                    fshow.mid = mid;
                    fshow.tarhid = tarhid;
                    fshow.typeid = typeid;
                    fshow.ispardakht = ispardakht.Checked;
                    fshow.nAmount = (int)nAmount.Value;
                    fshow.nCount = (int)nCount.Value;
                    fshow.foldername = fd;

                    fshow.Show();
                }
                else
                {
                    MessageBox.Show("طرح انتخاب نشده است");
                }

            }
            else
            {
                MessageBox.Show("نام مرحوم یا نام طرف نمی تواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private Image get_tarh(string tarhp, string ttxtst = null)
        {
            WriteImage tarh = new WriteImage(tarhp);
            MarhoomName marhoom = new MarhoomName();

            marhoomtxt.text = marhoom.addmarhoom(mtxt.Text, ismarhomeh.Checked);
            if (ttxtst == null)
            {
                ttxtst = ttxt.Text;
            }
            aztarftxt.text = ttxtst;

            tarh.createtext(marhoomtxt);
            tarh.createtext(aztarftxt);
            return tarh.cbitmap;
        }

        private void btnchap_Click(object sender, EventArgs e)
        {

            int marhomkerayeh;
            if (mid != null)
            {
                marhomkerayeh = (int)mid;
            }
            else
            {
                using (UnitOfWork db2 = new UnitOfWork())
                {
                    db2.MarhomRepository.Insert(new kheirieh.datalayer.marhoom()
                    {
                        name = mtxt.Text,
                        date = DateTime.Now
                    });
                    db2.Save();
                    marhomkerayeh = db2.MarhomRepository.Get().Select(p => p.id).Last();
                }
            }

            if (persons == null || persons.Count == 0)
            {

                PrintTarh print = new PrintTarh();
                print.print(get_tarh(tarhpth));


                int trafkerayeh;
                if (tid != null)
                {
                    trafkerayeh = (int)tid;
                }
                else
                {
                    using (UnitOfWork db1 = new UnitOfWork())
                    {
                        db1.PersonRepository.Insert(new kheirieh.datalayer.person()
                        {
                            name = ttxt.Text,
                        });
                        db1.Save();
                        trafkerayeh = db1.PersonRepository.Get().Select(p => p.id).Last();
                    }
                }

                using (UnitOfWork db = new UnitOfWork())
                {
                    db.KerayehRepository.Insert(new kheirieh.datalayer.kerayeh()
                    {
                        usertraf = trafkerayeh,
                        type = (typeid != null) ? (int)typeid : 1,
                        marhom = marhomkerayeh,
                        tarh = (tarhid != null) ? (int)tarhid : 1,
                        date = DateTime.Now,
                        ispardakht = (ispardakht.Checked) ? 1 : 0,
                        amountpay = (int)nAmount.Value * (int)nCount.Value,
                        count = (int)nCount.Value
                    });
                    db.Save();
                }

            }
            else
            {
                wait wait = new wait();
                wait.Show();

                foreach (person p in persons)
                {
                    PrintTarh print = new PrintTarh();
                    print.print(get_tarh(tarhpth, p.name), false);

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.KerayehRepository.Insert(new kheirieh.datalayer.kerayeh()
                        {
                            usertraf = p.id,
                            type = (typeid != null) ? (int)typeid : 1,
                            marhom = marhomkerayeh,
                            tarh = (tarhid != null) ? (int)tarhid : 1,
                            date = DateTime.Now,
                            ispardakht = (ispardakht.Checked) ? 1 : 0,
                            amountpay = (int)nAmount.Value,
                            count = (int)nCount.Value
                        });
                        db.Save();
                    }
                }

                MessageBox.Show("عملیات چاپ به اتمام رسید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wait.Close();
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgperson.AutoGenerateColumns = false;
                dgperson.DataSource = db.PersonRepository.Get(null, LimitTables);

                dgtajtype.AutoGenerateColumns = false;
                dgtajtype.DataSource = db.TajRepository.Get(null, LimitTables);

                dgtarhs.AutoGenerateColumns = false;
                dgtarhs.DataSource = db.TemplateRepository.Get(null, LimitTables);
            }
        }

        private void dgmarhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxt.Text = dgmarhom.CurrentRow.Cells[1].Value.ToString();
            mid = (int)dgmarhom.CurrentRow.Cells[0].Value;
        }

        private void ttxt_Enter(object sender, EventArgs e)
        {

            tabControl1_Click(null, null);
            tabControl1.SelectTab(1);



        }

        private void mtxt_Enter(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void dgtajtype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            typeid = (int)dgtajtype.CurrentRow.Cells[0].Value;
            ttype.Text = dgtajtype.CurrentRow.Cells[1].Value.ToString();
            nAmount.Value = (int)dgtajtype.CurrentRow.Cells[2].Value;
        }

        private void dgperson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ttxt.Text = dgperson.CurrentRow.Cells[1].Value.ToString();
            tid = (int)dgperson.CurrentRow.Cells[0].Value;
        }

        private void dgtarhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string foldername = dgtarhs.CurrentRow.Cells[2].Value.ToString();
            insertTarh(foldername, (int)dgtarhs.CurrentRow.Cells[0].Value, dgtarhs.CurrentRow.Cells[1].Value.ToString());
        }

        private void insertTarh(string foldername, int tid, string tarhname)
        {
            try
            {
                XmlProcessor xml = new XmlProcessor(foldername);
                marhoomtxt = xml.gettext(0);
                aztarftxt = xml.gettext(1);
                fd = foldername;

                tarhpth = GetSeting.getDefulttemplatePtah() + "/" + foldername + "/" + xml.getimage(0).imgname;

                tarhpic.ImageLocation = GetSeting.getDefulttemplatePtah() + "/" + foldername + "/" + xml.getimage(0).imgname;
                xml = null;

                tarhid = tid;
                labeltrah.Text = tarhname;
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در بارگزاری تصویر طرح");
            }
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fabout = new About();
            fabout.Show();
        }

        private void dgperson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgtajtype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ispayed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void چاپهوشمندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartPrint smartPrint = new SmartPrint();
            smartPrint.Show();
        }

        private void تنظیماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMSeting frmSeting = new FRMSeting();
            frmSeting.ShowDialog();
            if (frmSeting.DialogResult == DialogResult.OK)
            {
                Form1_Load(null, null);
            }
        }

        private void mtxt_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (mtxt.Text != "")
                {
                    dgmarhom.DataSource = db.NGmarhoomRepository.GetByFilterName(mtxt.Text);
                }
                else
                {
                    dgmarhom.DataSource = db.MarhomRepository.Get(null, LimitTables);
                }

            }
        }

        private void ttxt_TextChanged(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                if (ttxt.Text != "")
                {
                    dgperson.DataSource = db.NGPersonRepository.GetByFilterName(ttxt.Text);
                }
                else
                {
                    dgperson.DataSource = db.PersonRepository.Get(null, LimitTables);
                }

            }

        }

        private void طراحیطرحجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMDesigning fRMDesigning = new FRMDesigning();
            fRMDesigning.Show();
        }

        private void نصببستههایگرافیکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMInestallTarh fRMInestall = new FRMInestallTarh();
            fRMInestall.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void سفارشاتآنلاینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("این گزینه در آینده فعال خواهد شد.", "در دست ساخت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        List<person> persons;
        private void btnmultiselect_Click(object sender, EventArgs e)
        {
            FRMMultiSelect fRMMulti = new FRMMultiSelect();
            fRMMulti.persons = persons;
            if (fRMMulti.ShowDialog() == DialogResult.OK)
            {
                persons = fRMMulti.persons;
                ttxt.Text = "چند نفر انتخاب شده (برای پاک کردن کلیک کنید)";
            }
        }

        private void گزارشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMReport fRMReport = new FRMReport();
            fRMReport.Show();
        }

        private void ttxt_Click(object sender, EventArgs e)
        {
            if (persons != null)
            {
                persons.Clear();
                ttxt.Text = "";
            }
        }

        private void کرایههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMlistKerayeh frm = new FRMlistKerayeh();
            frm.Show();
        }

        private void حسابداریToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void انبارداریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMManageRows frm = new FRMManageRows();
            frm.type = "anbar";
            frm.Show();
        }

        private void لیستمرحومهامراسماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMManageRows frm = new FRMManageRows();
            frm.type = "marhoom";
            frm.Show();
        }

        private void اشخاصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMManageRows frm = new FRMManageRows();
            frm.type = "person";
            frm.Show();
        }
    }
}
