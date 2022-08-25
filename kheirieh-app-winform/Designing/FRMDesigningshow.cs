using kheirieh.datalayer.Context;
using kheirieh.graphic;
using kheirieh.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform
{
    public partial class FRMDesigningshow : Form
    {
        public FRMDesigningshow()
        {
            InitializeComponent();
        }

        public Image img;
        public TextData marhoomtxt;
        public TextData aztarftxt;
        public string tarhp;

        public int? tid;
        public int? mid;
        public int? tarhid;
        public int? typeid;

        public bool ispardakht;
        public int nAmount;
        public int nCount;
        public string foldername;

        private void FRMDesigning_Load(object sender, EventArgs e)
        {
            tarhpic.Image = img;

            nMX.Value = marhoomtxt.px;
            nMY.Value = marhoomtxt.py;
            nMS.Value = marhoomtxt.size;

            nTX.Value = aztarftxt.px;
            nTY.Value = aztarftxt.py;
            nTS.Value = aztarftxt.size;
        }

        private void btnshowtaghirat_Click(object sender, EventArgs e)
        {
            if (tarhp != null)
            {
                WriteImage tarh = new WriteImage(tarhp);

                marhoomtxt.px = (int)nMX.Value;
                marhoomtxt.py = (int)nMY.Value;
                marhoomtxt.size = (int)nMS.Value;

                aztarftxt.px = (int)nTX.Value;
                aztarftxt.py = (int)nTY.Value;
                aztarftxt.size = (int)nTS.Value;

                // write texts
                tarh.createtext(marhoomtxt);
                tarh.createtext(aztarftxt);

                img = tarh.cbitmap;
                tarhpic.Image = tarh.cbitmap;

            }
            else
            {
                MessageBox.Show("طرح انتخاب شده یافت نشد");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnshowtaghirat_Click(null, null);
            PrintTarh print = new PrintTarh();
            print.print(img);

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
                        name = aztarftxt.text,
                    });
                    db1.Save();
                    trafkerayeh = db1.PersonRepository.Get().Select(p => p.id).Last();
                }
            }

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
                        name = marhoomtxt.text,
                        date = DateTime.Now
                    });
                    db2.Save();
                    marhomkerayeh = db2.MarhomRepository.Get().Select(p => p.id).Last();
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
                    ispardakht = (ispardakht) ? 1 : 0,
                    amountpay = nAmount,
                    count = nCount
                });
                db.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            btnshowtaghirat_Click(null, null);
            saveSeting();
        }

        private void btnsaveforever_Click(object sender, EventArgs e)
        {
            btnshowtaghirat_Click(null, null);

            if (MessageBox.Show(
                "تنظیماتی که انجام داده اید بروی فایل اصلی طرح اعمال خواهد شد و تنظیمات قبلی قابل بازیابی نمیباشد",
                "توجه",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                )
                == DialogResult.OK)
            {
                saveSeting(true);
            }

        }

        private void btnTfont_Click(object sender, EventArgs e)
        {
            FontselectDialogShow(aztarftxt,nTS);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FontselectDialogShow(marhoomtxt, nMS);
        }

        private void FontselectDialogShow(TextData txt, NumericUpDown Ninpout)
        {
            FontDialog fontd = new FontDialog() {
                AllowScriptChange = false,
                ShowHelp = false,
                ShowEffects = false,
                Font = new Font(txt.font, (float)txt.size)
            };

            if (fontd.ShowDialog() == DialogResult.OK)
            {
                txt.font = fontd.Font.Name;
                Ninpout.Value = txt.size = (int)fontd.Font.Size;
                btnshowtaghirat_Click(null, null);
            }
        }

        private void saveSeting(bool save = false)
        {
            XmlProcessor xml = new XmlProcessor(foldername);
            xml.editXml(0, marhoomtxt);
            xml.editXml(1, aztarftxt);
            if (save)
            {
                xml.savefile(foldername);
            }
        }
    }
}
