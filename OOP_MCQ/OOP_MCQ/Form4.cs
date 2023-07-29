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
    public partial class Form4 : Form
    {
        public static string[] CrctAnswers = new string[5];
        Question[] Questions = new Question[5];
        int Page = 0;
        public static string [] selection = new string[5];
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            button2.Enabled = false;
            button3.Enabled = false;
            string[] AllLines = File.ReadAllLines("C:\\MCQ\\"+Form3.level+".txt");
            string[] ar = new string[5];
             
            for (int i = 0; i < AllLines.Length; i++)
            {
                ar = AllLines[i].Split('|');
                Question q = new Question(ar[0], ar[1], ar[2], ar[3], ar[4]);
                Questions[i] = q;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
           string[] QuestionElements = Questions[Page].ToString().Split('|');

            label2.Text = QuestionElements[0];
            radioButton1.Text = QuestionElements[1];
            radioButton2.Text = QuestionElements[2];
            radioButton3.Text = QuestionElements[3];
            CrctAnswers[Page] = QuestionElements[4];
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
       
            if (Page == 0 || Page == 1 || Page == 2 || Page == 3 || Page == 4)
            {
                if (radioButton1.Checked)
                {
                    selection[Page] = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    selection[Page] = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    selection[Page] = radioButton3.Text;
                }
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            Page++;
            string[] QuestionElements = Questions[Page].ToString().Split('|');

            label2.Text = QuestionElements[0];
            radioButton1.Text = QuestionElements[1];
            radioButton2.Text = QuestionElements[2];
            radioButton3.Text = QuestionElements[3];
            CrctAnswers[Page] = QuestionElements[4];

            if (Page == 4)
            {
                button3.Enabled = true;
            }
            if (Page != 4)
            {
                button3.Enabled = false;
            }
            if (Page > 0)
            {
                button2.Enabled = true;
            }
            if (Page == 4)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            Page--;
            String[] QuestionElements = Questions[Page].ToString().Split('|');

            label2.Text = QuestionElements[0];
            radioButton1.Text = QuestionElements[1];
            radioButton2.Text = QuestionElements[2];
            radioButton3.Text = QuestionElements[3];
            CrctAnswers[Page] = QuestionElements[4];

            if (Page > 0)
            {
                button1.Enabled = true;
            }
            if (Page <=4)
            {
                button2.Enabled = true;
            }
            if (Page == 0)
            {
                button2.Enabled = false;
            }
            if (Page == 4)
            {
                button3.Enabled = true;
            }
            if (Page != 4)
            {
                button3.Enabled = false;
            }
                if (radioButton1.Checked)
                {
                    selection[Page] = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    selection[Page] = radioButton2.Text;
                }
                if (radioButton3.Checked)
                {
                    selection[Page] = radioButton3.Text;
                }
              
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selection[Page] = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                selection[Page] = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                selection[Page] = radioButton3.Text;
            }
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
