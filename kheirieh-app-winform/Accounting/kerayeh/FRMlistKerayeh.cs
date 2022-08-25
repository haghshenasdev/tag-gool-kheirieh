using kheirieh.datalayer.Context;
using kheirieh_app_winform.Accounting.kerayeh;
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
    public partial class FRMlistKerayeh : Form
    {
        public FRMlistKerayeh()
        {
            InitializeComponent();
        }

        private void FRMlistKerayeh_Load(object sender, EventArgs e)
        {
            //waiting form
            wait waitf = new wait();
            waitf.Show();
            //////////////

            BindGird();

            waitf.Close();
        }

        private void BindGird()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgview.AutoGenerateColumns = false;
                dgview.DataSource = db.NGKerayehRepository.joink();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            BindGird();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgview.CurrentRow != null)
            {
                int id = getid();
                if (MessageBox.Show("آیا مایل به حذف مورد انتخاب شده هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            db.KerayehRepository.Delete(id);
                            db.Save();
                        }

                        BindGird();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("مورد انتخاب شده حذف نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }
        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showeditform();
        }

        private void showeditform()
        {
            if (dgview.CurrentRow != null)
            {
                FRMEditOrAddKerayeh FEK = new FRMEditOrAddKerayeh();
                FEK.id = getid();
                FEK.ShowDialog();
            }
            else
            {
                MessageBox.Show(" لطفا یک مورد را از لیست انتخاب کنید", "توجه");
            }

        }

        private int getid()
        {
            return (int)dgview.CurrentRow.Cells[0].Value;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            showeditform();
        }
    }
}
