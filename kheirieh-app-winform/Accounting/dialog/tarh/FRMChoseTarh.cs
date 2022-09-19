using kheirieh.datalayer;
using kheirieh.datalayer.Context;
using kheirieh.graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kheirieh_app_winform.Accounting.dialog.tarh
{
    public partial class FRMChoseTarh : Form
    {
        public FRMChoseTarh()
        {
            InitializeComponent();
        }

        public int? retunedid = null;

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (dgtarhs.CurrentRow != null)
            {
                retunedid = (int)dgtarhs.CurrentRow.Cells[0].Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgtarhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showimagetarh(dgtarhs.CurrentRow.Cells[2].Value.ToString());
        }

        private void showimagetarh(string foldername)
        {
            try
            {
                XmlProcessor xml = new XmlProcessor(foldername);

                tarhpic.ImageLocation = GetSeting.getDefulttemplatePtah() + "/" + foldername + "/" + xml.getimage(0).imgname;
                xml = null;
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در بارگزاری تصویر طرح");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtsearch.Text != "")
                {
                    dgtarhs.DataSource = db.NGTemplateRepository.GetByFilterName(txtsearch.Text);
                }
                else
                {
                    dgtarhs.DataSource = db.TemplateRepository.Get();
                }
            }
        }

        private void FRMChoseTarh_Load(object sender, EventArgs e)
        {
            dgtarhs.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgtarhs.DataSource = db.TemplateRepository.Get();
                if (retunedid != null)
                {
                    showimagetarh(db.TemplateRepository.GetByID((int)retunedid).path);
                }
            }
            
        }
    }
}
