using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface_AM
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
