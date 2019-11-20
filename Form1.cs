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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            사용자 user = new 사용자();
            user.Show();
        }

        public void createFile()
        {
            FileStream fs = new FileStream("WorkDate.txt", FileMode.Append, FileAccess.Write);
            //FileMode중 append는 이어쓰기. 파일이 없으면 만든다.
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("log.txt"))
            {
                string log = file.ReadToEnd();

                if(log.Contains(textBox1.Text) == true && log.Contains(textBox2.Text) == true)
                {
                    MessageBox.Show("있음");

                    if (radioButton1.Checked == true)
                    {
                        고용주 president = new 고용주(textBox1.Text + ".txt");
                        president.Show();
                    }

                    if (radioButton2.Checked == true)
                    {
                        EmployeeForm employee = new EmployeeForm(textBox1.Text + ".txt");
                        employee.Show();
                    }   
                }

                if (radioButton3.Checked == true)
                {
                    if (textBox1.Text == "adminmaster" && textBox2.Text == "admin")
                    {
                        MessageBox.Show("관리자 권한으로 로그인 합니다");
                        관리자 managment = new 관리자();
                        managment.Show();
                    }
                    else MessageBox.Show("없음");
                }

                else
                    MessageBox.Show("없음");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
