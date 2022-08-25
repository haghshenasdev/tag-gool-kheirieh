using kheirieh.datalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kheirieh_app_winform
{
    public partial class FRMReport : Form
    {
        public FRMReport()
        {
            InitializeComponent();
        }

        private void FRMReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var datakerayeh = db.KerayehRepository.Get();
                var datamarhoom = db.MarhomRepository.Get();

                int monthnow = DateTime.Now.Month;
                int yearnow = DateTime.Now.Year;

                lbldaramadmonth.Text = datakerayeh.Where(k => k.ispardakht == 1 && k.date.Month == monthnow).Select(k => k.amountpay).Sum().ToString();
                lblgolcountmonth.Text = datakerayeh.Where(k => k.date.Month == monthnow).Select(k => k.count).Sum().ToString();
                lblcountmarasemmonth.Text = datamarhoom.Where(m => m.date.Month == monthnow).Count().ToString();

                lbldaramadyear.Text = datakerayeh.Where(k => k.ispardakht == 1 && k.date.Year == yearnow).Select(k => k.amountpay).Sum().ToString();
                lblgolcountyear.Text = datakerayeh.Where(k => k.date.Year == yearnow).Select(k => k.count).Sum().ToString();
                lblcountmarasemyear.Text = datamarhoom.Where(m => m.date.Year == yearnow).Count().ToString();

                lbldaramad.Text = datakerayeh.Where(k => k.ispardakht == 1).Select(k => k.amountpay).Sum().ToString();
                lblgolcount.Text = datakerayeh.Select(k => k.count).Sum().ToString();
                lblcountmarasem.Text = datamarhoom.Count().ToString();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FRMlistKerayeh frm = new FRMlistKerayeh();
            frm.Show();
        }
    }
}
