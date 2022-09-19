using kheirieh.datalayer;
using kheirieh.graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using kheirieh.datalayer.Context;
using kheirieh.utility.convertor;

namespace kheirieh_app_winform
{
    public partial class FRMDesigning : Form
    {
        public FRMDesigning()
        {
            InitializeComponent();
        }

        string foldername;
        TextData marhoomtxt;
        TextData aztarftxt;
        public int? id;

        private void FRMDesigning_Load(object sender, EventArgs e)
        {
            string mfont = "B Titr";
            string tfont = "B Titr";

            if (id != null)
            {
                this.Text = "ویرایش طرح";
                tarhfoldrname.Enabled = btnchosebac.Enabled = false;
                XmlProcessor xml;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var tarhdata = db.TemplateRepository.GetByID(id);

                    xml = new XmlProcessor(tarhdata.path);

                    txtpath.Text = foldername = GetSeting.getDefulttemplatePtah(db) + "\\" + tarhdata.path + "\\" + xml.getimage(0).imgname;
                    tarhname.Text = tarhdata.name;
                    tarhfoldrname.Text = tarhdata.path;
                }

                var mtd = xml.gettext(0);

                mfont = mtd.font;
                nMS.Value = mtd.size;
                nMX.Value = mtd.px;
                nMY.Value = mtd.py;
                mcolor.BackColor = DateConvertor.StringToColor(mtd.color);

                var ttd = xml.gettext(1);

                tfont = ttd.font;
                nTS.Value = ttd.size;
                nTX.Value = ttd.px;
                nTY.Value = ttd.py;
                tcolor.BackColor = DateConvertor.StringToColor(ttd.color);
            }

            marhoomtxt = new TextData()
            {
                text = "مرحوم نمونه",
                font = mfont,
                size = (int)nMS.Value,
                px = (int)nMX.Value,
                py = (int)nMY.Value,
                color = mcolor.BackColor.ToArgb().ToString()

            };
            aztarftxt = new TextData()
            {
                text = "طرف نمونه",
                font = tfont,
                size = (int)nTS.Value,
                px = (int)nTX.Value,
                py = (int)nTY.Value,
                color = tcolor.BackColor.ToArgb().ToString()
            };

            if (id != null) btnshowtaghirat_Click(null, null);
        }

        private void btnshowtaghirat_Click(object sender, EventArgs e)
        {
            try
            {
                marhoomtxt.size = (int)nMS.Value;
                marhoomtxt.px = (int)nMX.Value;
                marhoomtxt.py = (int)nMY.Value;
                marhoomtxt.color = mcolor.BackColor.ToArgb().ToString();

                aztarftxt.size = (int)nTS.Value;
                aztarftxt.px = (int)nTX.Value;
                aztarftxt.py = (int)nTY.Value;
                aztarftxt.color = tcolor.BackColor.ToArgb().ToString();

                if (foldername != null)
                {
                    WriteImage tarh = new WriteImage(foldername);

                    // write texts
                    tarh.createtext(marhoomtxt);
                    tarh.createtext(aztarftxt);

                    tarhpic.Image = tarh.cbitmap;
                    tarh = null;
                }
                else
                {
                    MessageBox.Show("لطفا یک زمینه انخاب کنید");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در پردازش", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnchosebac_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                foldername = txtpath.Text = file.FileName;
                btnshowtaghirat_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chosedcolor(tcolor);
        }

        private void chosedcolor(Panel showpanel)
        {
            ColorDialog colordg = new ColorDialog();
            if (colordg.ShowDialog() == DialogResult.OK)
            {
                showpanel.BackColor = colordg.Color;
                btnshowtaghirat_Click(null, null);
            }
        }

        private void btnchosecolorm_Click(object sender, EventArgs e)
        {
            chosedcolor(mcolor);
        }

        private void chosefontm_Click(object sender, EventArgs e)
        {
            FontselectDialogShow(marhoomtxt, nMS);
        }

        private void FontselectDialogShow(TextData txt, NumericUpDown Ninpout)
        {
            FontDialog fontd = new FontDialog()
            {
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

        private void chosefontt_Click(object sender, EventArgs e)
        {
            FontselectDialogShow(aztarftxt, nTS);
        }

        //private void ValueChanged(object sender, EventArgs e)
        //{
        //    btnshowtaghirat_Click(null, null);
        //}

        private void btnsaveforever_Click(object sender, EventArgs e)
        {
            if (tarhfoldrname.Text != "")
            {
                if (tarhname.Text != "")
                {
                    if (id == null)
                    {
                        try
                        {

                            string p = GetSeting.getDefulttemplatePtah() + "\\" + tarhfoldrname.Text;
                            string filename = Path.GetFileName(foldername);

                            //copy and create folder
                            if (Directory.Exists(p))
                            {
                                if (MessageBox.Show("این پوشه وجود دارد و ممکن است برای طرح دیگری باشد. آیا می خواهید ادامه دهید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                {
                                    return;
                                }
                            }
                            else
                            {
                                Directory.CreateDirectory(p);
                            }

                            //waiting form
                            wait waitf = new wait();
                            waitf.Show();
                            //////////////

                            File.Copy(foldername, p + "\\" + filename);
                            /////////////////////////

                            XmlProcessor xml = new XmlProcessor();
                            xml.CreateXmlFile(p, filename, tarhname.Text, marhoomtxt, aztarftxt);

                            using (UnitOfWork db = new UnitOfWork())
                            {
                                db.TemplateRepository.Insert(new template()
                                {
                                    name = tarhname.Text,
                                    path = tarhfoldrname.Text
                                });
                                db.Save();
                            }

                            waitf.Close();
                            MessageBox.Show("طرح با موفقیت ایجاد و ذخیره سازی شد");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("طرح ذخیره نشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        try
                        {
                            using (UnitOfWork db = new UnitOfWork())
                            {
                                tarhpic.Image = null;
                                tarhpic.ImageLocation = "";
                                var tarhdata = db.TemplateRepository.GetByID(id);
                                //if (tarhdata.path != tarhfoldrname.Text)
                                //{
                                //    string dpath = GetSeting.getDefulttemplatePtah(db);
                                //    string p1 = dpath + "\\" + tarhdata.path;
                                //    string p2 = dpath + "\\" + tarhfoldrname.Text;
                                //    Directory.Move(p1, p2);
                                //}
                                XmlProcessor xml = new XmlProcessor(tarhdata.path);
                                xml.editXml(0, marhoomtxt);
                                xml.editXml(1, aztarftxt);
                                xml.savefile(tarhdata.path);
                            }


                            using (UnitOfWork db = new UnitOfWork())
                            {
                                db.TemplateRepository.Update(new template()
                                {
                                    id = (int)id,
                                    name = tarhname.Text,
                                });
                                db.Save();
                            }

                            DialogResult = DialogResult.OK;

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show($"{er.Message} خطا در ذخیره سازی", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("لطفا نام طرح را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("لطفا نام پوشه را وارد نماید");
            }

        }
    }
}
