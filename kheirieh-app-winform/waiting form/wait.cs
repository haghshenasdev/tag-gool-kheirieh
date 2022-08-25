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
    public partial class wait : Form
    {
        public wait()
        {
            InitializeComponent();
        }

        private void wait_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Label textwait = new Label()
            {
                Text = "لطفا منتظر بمانید...",
                Location = new Point(31, 53),
                TabIndex = 1,
                Size = new Size(111,14)
            };
            PictureBox picload = new PictureBox()
            {
                Image = Properties.Resources.loding2,
                Location = new Point(148, 25),
                Size = new Size(100,66),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            this.Controls.Add(textwait);
            this.Controls.Add(picload);
        }
    }
}
