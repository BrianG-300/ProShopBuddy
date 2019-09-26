using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProShopApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            //Opening AddSpecs Form
            FrmAddSpecs Add = new FrmAddSpecs();
            Add.Show();
        }

        private void btnLoadSpec_Click(object sender, EventArgs e)
        {
            //Opening LoadSpecs Form
            FrmLoadSpecs Load = new FrmLoadSpecs();
            Load.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
