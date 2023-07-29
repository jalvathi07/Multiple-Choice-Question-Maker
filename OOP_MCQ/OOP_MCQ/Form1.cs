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
    public partial class Form1 : Form
    {
        public static string name = "";
        public static string rollno = "";
        public string fileCheck = "";
        public static string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileCheck = "C:\\MCQ\\results\\" + textBox2.Text + ".txt";
            if (File.Exists(fileCheck) == true)
            {
                label4.Text = "You Have Already Responded ! ";
            }
            if(textBox1.Text!=""&&textBox2.Text!=""&&File.Exists(fileCheck)==false&&textBox2.Text.Length>=5)
            {
                label5.Text = "";
                label4.Text = "";
                fileName = textBox2.Text;
                File.WriteAllText("C:\\MCQ\\results\\" + textBox2.Text + ".txt", "");
                student s = new student(textBox1.Text, textBox2.Text);
                MessageBox.Show("ROLLNO: " + s.rollno, "WELCOME: " + s.name);
                name = s.name;
                rollno = s.rollno;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label5.Text = "* Name is Required ";
            }
            if (textBox1.Text != "")
            {
                label5.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length<5)
            {
                label4.Text = "Roll_Number contains atleast 5 characters";
                button1.Enabled = false;
            }
            if (textBox2.Text.Length>=5)
            {
                label4.Text = "";
                button1.Enabled = true;
            }
        }
    }
}
