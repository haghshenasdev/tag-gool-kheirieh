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
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }
        public Image img;
        private void show_Load(object sender, EventArgs e)
        {
            picview.Image = img;
        }
    }
}
