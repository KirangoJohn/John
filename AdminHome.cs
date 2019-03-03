using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void itemsStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsData itemsR = new ItemsData();

            itemsR.Dispose();
            itemsR = null;
        }
    }
}
