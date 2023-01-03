using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       private List<List<Contestants>> GroupList = new List<List<Contestants>>();
       private List<Contestants> members = new List<Contestants>();
       private int groupcounter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (members.Count != 3)
            {
                Contestants contestant = new Contestants();
                contestant.Name = textBox1.Text;
                contestant.Age = (int)numericUpDown1.Value;
                switch (contestant.Age)
                {
                    case 13:
                        contestant.Type = 0;
                        break;
                    case 14:
                        contestant.Type = 1;
                        break;
                    case 15:
                        contestant.Type = 1;
                        break;
                    case 16:
                        contestant.Type = 2;
                        break;
                    case 17:
                        contestant.Type = 2;
                        break;
                    default:
                        break;
                }
                contestant.Group = groupcounter;
                members.Add(contestant);
                listBox1.Items.Add(contestant.Name);
            }
            else
            {
                try
                {
                    throw new Exception("Member limit reached!");
                }
                catch(Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            members = new List<Contestants>();
            groupcounter++;
            listBox1.Items.Clear();
            listBox2.Items.Add("Group" + groupcounter);
        }

        
    }
}
