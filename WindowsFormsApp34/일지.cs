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
    public partial class 일지 : Form
    {
        private EmployeeForm form1 = null;
        public 일지(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            근무일지_직원용_ report = new 근무일지_직원용_(this);
            report.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("근무일지를 종료합니다");
            Close();
        }

        public void setDate()
        {
            StreamReader sr = new StreamReader("WorkDate.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] textValue = line.Split(' ');
                foreach (var item in textValue)
                {
                    if (item != "")
                    {
                        comboBox1.Items.Add(item);
                    }
                }
            }
            sr.Close();
        }

        public void selectName(string name)
        {
            if (comboBox1.Text == name)
            {
                StreamReader sr = new StreamReader(name + ".txt");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] textValue = line.Split(' ');
                    textBox1.Text = textValue[0];
                    textBox3.Text = textValue[2];
                    textBox2.Text = textValue[3];
                    textBox4.Text = textValue[5];

                    if (textValue[1] == "오전")
                        radioButton1.Checked = true;
                    if (textValue[1] == "오후")
                        radioButton2.Checked = true;
                    if (textValue[4] == "오전")
                        radioButton3.Checked = true;
                    if (textValue[4] == "오후")
                        radioButton4.Checked = true;
                }
                sr.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
                MessageBox.Show("등록된 데이터가 없습니다");
            else
                selectName(comboBox1.Text);
        }
    }
}
