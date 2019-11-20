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

namespace WindowsFormsApp34
{
    public partial class 관리자 : Form
    {
        public 관리자()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("log.txt"))
            {
                string log = file.ReadToEnd();

                if (log.Contains(textBox1.Text) == true)
                {
                    readFile(textBox1.Text + ".txt");
                }
            }
        }

        public void readFile(string FileName)
        {
            if (radioButton1.Checked == true)
            {
                StreamReader sr = new StreamReader(FileName);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] Value = line.Split(' ');
                    textBox2.Text = Value[0];
                    textBox3.Text = Value[1];
                }
                sr.Close();
            }

            if (radioButton2.Checked == true)
            {
                StreamReader sr = new StreamReader(FileName);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] Value = line.Split(' ');
                    textBox5.Text = Value[0];
                    textBox4.Text = Value[2];
                }
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            고용주 Company = new 고용주(textBox1.Text + ".txt");
            Company.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm(textBox1.Text + ".txt");
            employee.Show();
        }
    }
}
