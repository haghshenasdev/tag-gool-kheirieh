using kheirieh.datalayer.Context;
using kheirieh.utility;
using kheirieh.utility.convertor;
using kheirieh_app_winform.Accounting.kerayeh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            waitf.BackgroundImage = Properties.Resources.waitimg;
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
                if (FEK.ShowDialog() == DialogResult.OK)
                {
                    BindGird();
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                List<KerayehJoin> d = db.NGKerayehRepository.joink();
                if (textBox1.Text != "")
                {
                    dgview.DataSource = d.Where(i => i.marhom.Contains(textBox1.Text) || i.usertraf.Contains(textBox1.Text)).ToList();
                }
                else
                {
                    dgview.DataSource = d;
                }

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<KerayehJoin> res = new List<KerayehJoin>();
                res.AddRange(db.NGKerayehRepository.joink());

                if (textBox1.Text != "")
                {
                    res = res.Where(i => i.marhom.Contains(textBox1.Text) || i.usertraf.Contains(textBox1.Text)).ToList();
                }

                if ((chp.Checked && !chnp.Checked) || (!chp.Checked && chnp.Checked))
                {
                    if (chp.Checked)
                        res = res.Where(r => r.ispardakht == 1).ToList();
                    if (chnp.Checked)
                        res = res.Where(r => r.ispardakht == 0).ToList();
                }

                if (txtFromDate.Text != "    /  /")
                {
                    DateTime StartDate = Convert.ToDateTime(txtFromDate.Text);
                    StartDate = DateConvertor.ToMilady(StartDate);
                    res = res.Where(r => r.date >= StartDate).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    DateTime EndtDate = Convert.ToDateTime(txtToDate.Text);
                    EndtDate = DateConvertor.ToMilady(EndtDate);
                    res = res.Where(r => r.date <= EndtDate).ToList();
                }

                dgview.DataSource = null;
                dgview.DataSource = res;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FRMEditOrAddKerayeh fRM = new FRMEditOrAddKerayeh();
            if (fRM.ShowDialog() == DialogResult.OK)
            {
                BindGird();
            }
        }
    }
}
