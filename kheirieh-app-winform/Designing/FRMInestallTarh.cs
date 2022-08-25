using Aspose.Zip;
using kheirieh.datalayer;
using kheirieh.datalayer.Context;
using kheirieh.graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace kheirieh_app_winform
{
    public partial class FRMInestallTarh : Form
    {
        public FRMInestallTarh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Graphic Pakage Files For Kheirieh App (*.kht)|*.kht|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                wait fw = new wait();
                fw.Show();
                using (FileStream zipFile = File.Open(file.FileName, FileMode.Open))
                {
                    using (var archive = new Archive(zipFile))
                    {
                        // Unzip files to folder
                        archive.ExtractToDirectory(GetSeting.getDefulttemplatePtah());

                    }
                }
                using (UnitOfWork db = new UnitOfWork())
                {
                    var directories = Directory.GetDirectories(GetSeting.getDefulttemplatePtah()).Select(d => Path.GetFileName(d)).ToList();

                    var ft = db.TemplateRepository.Get().Select(f => f.path);
                    var res = directories.Except(ft).ToList();

                    foreach (var item in res)
                    {
                        XmlProcessor xml = new XmlProcessor(item);
                        string name = xml.getname();
                        db.TemplateRepository.Insert(new template()
                        {
                            name = (name != "") ? name : item,
                            path = item
                        });
                        db.Save();
                        xml = null;
                    }
                    FRMInestallTarh_Load(null, null);
                }
                fw.Close();
            }
        }

        private void FRMInestallTarh_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgtarhs.AutoGenerateColumns = false;
                dgtarhs.DataSource = db.TemplateRepository.Get(null, GetSeting.getLimitTables(db));
            }
        }

        private void dgtarhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string foldername = dgtarhs.CurrentRow.Cells[2].Value.ToString();
                XmlProcessor xml = new XmlProcessor(foldername);

                tarhpic.ImageLocation = GetSeting.getDefulttemplatePtah() + "/" + foldername + "/" + xml.getimage(0).imgname;
                xml = null;
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در بارگزاری تصویر طرح");
            }
        }

        private void btndeltarh_Click(object sender, EventArgs e)
        {
            if (dgtarhs.CurrentRow != null)
            {
                int id = (int)dgtarhs.CurrentRow.Cells[0].Value;
                if (MessageBox.Show("آیا مایل به حذف طرح انتخاب شده هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        string path = db.TemplateRepository.GetByID(id).path;
                        path = GetSeting.getDefulttemplatePtah(db) + "\\" + path;
                        Directory.Delete(path, true);
                    }
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.TemplateRepository.Delete(id);
                        db.Save();
                    }
                    FRMInestallTarh_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgtarhs.CurrentRow != null)
            {
                tarhpic.ImageLocation = null;
                FRMDesigning fd = new FRMDesigning();
                fd.id = (int)dgtarhs.CurrentRow.Cells[0].Value;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    FRMInestallTarh_Load(null, null);
                }
            }
                
        }
    }
}
