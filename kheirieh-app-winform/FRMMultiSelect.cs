using kheirieh.datalayer;
using kheirieh.datalayer.Context;
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
    public partial class FRMMultiSelect : Form
    {
        public FRMMultiSelect()
        {
            InitializeComponent();
        }
        int LimitTables;
        private void FRMMultiSelect_Load(object sender, EventArgs e)
        {
            dgperson.AutoGenerateColumns = false;
            dgperson.MultiSelect = true;
            dgperson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (UnitOfWork db = new UnitOfWork())
            {
                GetSeting.getLimitTables(db);
                dgperson.DataSource = db.PersonRepository.Get(null, LimitTables);
            }

            if (persons != null)
            {
                //dataGridView1.DataSource = persons;
                foreach (person p in persons)
                {
                    dataGridView1.Rows.Add(p.id,p.name);
                }
            }
            else
            {
                persons = new List<person>();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                foreach (DataGridViewRow row in dgperson.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; ++i)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    this.dataGridView1.Rows.Add(rowData);
                }

                dgperson.ClearSelection();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnaddtolist_Click(null, null);
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
           .OfType<DataGridViewRow>()
           .Where(row => !row.IsNewRow)
           .ToArray();

            foreach (var row in selectedRows)
                dataGridView1.Rows.Remove(row);

            dataGridView1.ClearSelection();
        }

        public List<person> persons;
        private void btnok_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if(persons != null)persons.Clear();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    person p = new person()
                    {
                        id = (int)row.Cells[0].Value,
                        name = row.Cells[1].Value.ToString()
                    };
                    persons.Add(p);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtsearch.Text != "")
                {
                    dgperson.DataSource = db.NGPersonRepository.GetByFilterName(txtsearch.Text);
                }
                else
                {
                    dgperson.DataSource = db.PersonRepository.Get(null, LimitTables);
                }

            }
        }

        private void btnaddtolist_Click(object sender, EventArgs e)
        {
            if (tarafname.Text.Trim() != "")
            {
                int id;
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.PersonRepository.Insert(new person()
                    {
                        name = tarafname.Text,
                        phone = (tarafphone.Text.Trim() != "") ? tarafphone.Text : null,
                        adres = (tarafadress.Text.Trim() != "") ? tarafadress.Text : null
                    });
                    db.Save();
                    id = db.PersonRepository.Get().Select(p => p.id).Last();
                }
                object[] datarow = { id, tarafname.Text, };
                this.dataGridView1.Rows.Add(datarow);

                tarafname.Text = tarafadress.Text = tarafphone.Text = "";
            }
            else
            {
                MessageBox.Show("نام ازطرف نمی تواند خالی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
