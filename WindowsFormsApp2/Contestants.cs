using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Contestants
    {
        private string name;
        private int age;
        private int type; //0 - Fresh Scientist , 1 - Junior Scientist , 2 - Senior Scientist
        private int group;

        public string Name
        {
            get { return name; }   // get method
            set { name = value; }
        }
        public int Age
        {
            get { return age; }   // get method
            set { age = value; }
        }
        public int Type
        {
            get { return type; }   // get method
            set { type = value; }
        }
        public int Group
        {
            get { return group; }   // get method
            set { group = value; }
        }
    }
}
