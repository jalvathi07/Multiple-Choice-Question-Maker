using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_MCQ
{
    public partial class Form3 : Form
    {
        public static string level = "";
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                level = radioButton1.Text.ToLower();
            }
            if (radioButton2.Checked)
            {
                level = radioButton2.Text.ToLower();
            }
            if (radioButton3.Checked)
            {
                level = radioButton3.Text.ToLower();
            }
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
