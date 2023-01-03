using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQL
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void orderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmInfoForm = new Form1();
            frmInfoForm.MdiParent = this;
            frmInfoForm.StartPosition = FormStartPosition.CenterScreen;
            frmInfoForm.Show();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmOrderForm = new Form2();
            frmOrderForm.MdiParent = this;
            frmOrderForm.StartPosition = FormStartPosition.CenterScreen;
            frmOrderForm.Show();
        }
    }
}
