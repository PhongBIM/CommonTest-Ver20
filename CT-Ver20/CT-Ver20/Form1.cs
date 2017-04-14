using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_Ver20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void floorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floor fl = new Floor();
            fl.Show();
        }

        private void partitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partition pt = new Partition();
            pt.Show();
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Column cl = new Column();
            cl.Show();
        }
    }
}
