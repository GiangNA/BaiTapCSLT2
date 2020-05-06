using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_Bai1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chaoMungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaoMung c1 = new FrmChaoMung();
            c1.Show();
        }

        private void tinhTongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong c2 = new FrmTinhTong();
            c2.Show();
        }
    }
}
