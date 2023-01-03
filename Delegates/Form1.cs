using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void delegateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmDelegate = new Form2();
            frmDelegate.MdiParent = this;
            frmDelegate.Dock = DockStyle.Fill;
            frmDelegate.Show();
        }

        private void lambdaExpressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmLambda = new Form3();
            frmLambda.MdiParent = this;
            frmLambda.StartPosition = FormStartPosition.CenterScreen;
            frmLambda.Show();
        }

        private void builtInDelegatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frmBuiltIn = new Form4();
            frmBuiltIn.MdiParent = this;
            frmBuiltIn.StartPosition = FormStartPosition.CenterScreen;
            frmBuiltIn.Show();
        }

        private void ourVetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frmVet = new Form5();
            frmVet.MdiParent = this;
            frmVet.StartPosition = FormStartPosition.CenterScreen;
            frmVet.Show();
        }

        private void ourLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frmVetLoc = new Form6();
            frmVetLoc.MdiParent = this;
            frmVetLoc.StartPosition = FormStartPosition.CenterScreen;
            frmVetLoc.Show();
        }
    }
}
