using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_MCQ
{
    public partial class Form5 : Form
    {
        int marks = 0;
        public Form5()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Selected Level : " + Form3.level.ToUpper());
            Validation v = new Validation();
            v.CheckArray(Form4.selection);
            int n=1;
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add("Selected Answer for " + n++ + " th Question : " + Form4.selection[i]+" / "+Form4.CrctAnswers[i]);
            }
            marks = v.Validate(Form4.CrctAnswers, Form4.selection);
            listBox1.Items.Add("You Scored "+marks+"/ 10 :");
            listBox1.Items.Add("          ");
            listBox1.Items.Add("          ");
            listBox1.Items.Add("                         THANK YOU FOR YOUR KIND RESPONSE");



            StreamWriter sw = new StreamWriter("C:\\MCQ\\results\\" + Form1.fileName + ".txt");
            sw.WriteLine("Student's Name : " + Form1.name);
            sw.WriteLine("Student's Rollno : "+ Form1.rollno);
            sw.WriteLine("Selected level : " + Form3.level.ToUpper());
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine("Selected Answer for " + n++ + " th Question : " + Form4.selection[i] + " / " + Form4.CrctAnswers[i]);
            }
            sw.WriteLine("You Scored " + marks + "/ 10 :");
            sw.WriteLine("            ");
            sw.WriteLine("            ");
            sw.WriteLine("                            THANK YOU FOR YOUR KIND RESPONSE");
            sw.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
