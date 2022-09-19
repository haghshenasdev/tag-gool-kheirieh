using kheirieh.datalayer;
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
    public partial class SmartPrint : Form
    {
        public SmartPrint()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("لطفا ایتمی برای حذف انتخاب کنید ");
            }

        }

        List<int> marhoomWeekIds = new List<int>();
        List<int> marhoomChelomIds = new List<int>();
        List<int> marhoomYearIds = new List<int>();
        List<int> marhoomCoustomIds = new List<int>();

        private void btnAnalise_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            checkedList.Items.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var mdate = db.KerayehRepository.Get();

                int curentuserid = 0;
                foreach (var item in mdate)
                {
                    if (curentuserid != item.marhom)
                    {
                        InsertFilterData(CHweek.Checked, 7, item, db);
                        InsertFilterData(CHforteen.Checked, 40, item, db);
                        InsertFilterData(CHyear.Checked, 365, item, db);
                        InsertFilterData(CHcustom.Checked, (int)Ncustom.Value, item, db);
                    }

                    curentuserid = item.marhom;

                    progssesbar(mdate.Count());

                }
            }

            if (marhoomWeekIds.Count() != 0 || marhoomChelomIds.Count() != 0 || marhoomYearIds.Count() != 0 || marhoomCoustomIds.Count() != 0)
            {
                btnextarct.Enabled = true;
            }
            else
            {
                MessageBox.Show("هیچ موردی یافت نشد !");
            }
        }

        private void InsertFilterData(bool EnableFilter, int day, kerayeh item, UnitOfWork db)
        {
            if (EnableFilter && DateTime.Now.Subtract(item.date).Days == day)
            {
                marhoomWeekIds.Add(item.marhom);
                checkedList.Items.Add(db.MarhomRepository.GetByID(item.marhom).name, true);
            }
        }

        private void progssesbar(int count)
        {
            progressBar1.Maximum = count;

            if (progressBar1.Value >= count)
                progressBar1.Value = 0;

            progressBar1.Value += 1;

        }

        private void btnextarct_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            addednode(marhoomWeekIds, "week", "هفته");
            marhoomWeekIds.Clear();
            addednode(marhoomChelomIds, "chelom", "چهلم");
            marhoomChelomIds.Clear();
            addednode(marhoomYearIds, "year", "سال");
            marhoomYearIds.Clear();
            addednode(marhoomCoustomIds, "coustom", "روز دلخواه");
            marhoomCoustomIds.Clear();

            btndel.Enabled = btnStartPrint.Enabled = true;
        }

        private void addednode(List<int> listid, string keydasteh, string titledasteh)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (listid.Count() > 0)
                {
                    treeView1.Nodes.Add(keydasteh, titledasteh);

                    foreach (var item in listid)
                    {
                        treeView1.Nodes[keydasteh].Nodes.Add(item.ToString(), db.MarhomRepository.GetByID(item).name);
                        var kerahbymarhoomname = db.KerayehRepository.Get(k => k.marhom == item);

                        string curentpname = "";
                        foreach (var i in kerahbymarhoomname)
                        {
                            if (i.usertraf == null) continue;
                            string nameperson = db.PersonRepository.GetByID(i.usertraf).name;
                            if (curentpname != nameperson)
                            {
                                treeView1.Nodes[keydasteh].Nodes[item.ToString()].Nodes.Add(nameperson);
                            }
                            curentpname = nameperson;
                        }

                        progssesbar(listid.Count());
                    }
                }

            }
        }

        private void btnStartPrint_Click(object sender, EventArgs e)
        {
            PrintTarh print = new PrintTarh();

            template tarh;
            using (UnitOfWork db = new UnitOfWork())
            {
                tarh = GetSeting.getdefualttarh(db);
            }

            foreach (TreeNode item in treeView1.Nodes)
            {
                foreach (TreeNode marhoomname in item.Nodes)
                {
                    foreach (TreeNode personname in marhoomname.Nodes)
                    {
                        print.print(get_tarh(marhoomname.Text, personname.Text, tarh), false);
                    }
                    progssesbar(marhoomname.GetNodeCount(false));
                }
            }

        }

        private Image get_tarh(string marhoomnametxt, string aztaraftxt, template tarhdata)
        {
            XmlProcessor xml = new XmlProcessor(tarhdata.path);
            TextData marhoomtxt = xml.gettext(0);
            TextData aztarftxt = xml.gettext(1);

            WriteImage tarh = new WriteImage(Application.StartupPath + "/templates/" + tarhdata.path + "/" + xml.getimage(0).imgname);
            MarhoomName marhoom = new MarhoomName();

            marhoomtxt.text = marhoom.addmarhoom(marhoomnametxt);
            aztarftxt.text = aztaraftxt;

            tarh.createtext(marhoomtxt);
            tarh.createtext(aztarftxt);

            return tarh.cbitmap;
        }

        private void CHselectall_CheckedChanged(object sender, EventArgs e)
        {
            if (CHselectall.Checked)
            {
                for (int x = 0; x < checkedList.Items.Count; x++)
                {
                    checkedList.SetItemChecked(x, true);
                }
            }
            else
            {
                for (int x = 0; x < checkedList.Items.Count; x++)
                {
                    checkedList.SetItemChecked(x, false);
                }
            }

        }

        private void CHcustom_CheckedChanged(object sender, EventArgs e)
        {
            Ncustom.Enabled = CHcustom.Checked;
        }

        private void SmartPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
