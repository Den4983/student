using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Form2 : Form
    {
        //int max1;
       // StDbContext db;
        public Form2(/*int max*/)
        {
            //max1 = max;
            //using (StDbContext db = new StDbContext())
            //{
            //    max= db.Groups.LastOrDefault().id;
            //};
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // int max = db.Groups.LastOrDefault().id;
            //numericUpDown1.Maximum = (decimal)max1;
            numericUpDown1.Maximum = 200;
        }
    }
}
