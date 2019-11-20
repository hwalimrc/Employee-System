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
using System.Text.RegularExpressions;

namespace WindowsFormsApp34
{
    public partial class 근무일지_관리자용 : Form
    {
        private 고용주 form1 = null;
        public 근무일지_관리자용(고용주 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            setDate();
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
            textBox1.Clear(); textBox2.Clear();
            textBox3.Clear(); textBox4.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("근무일지를 종료합니다");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
                MessageBox.Show("등록된 데이터가 없습니다");
            else
                selectName(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fileDel = new FileInfo(comboBox1.Text + ".txt");
            if (fileDel.Exists) //삭제할 파일이 있는지
            {
                fileDel.Delete(); //없어도 에러안남
            }
            ReplaceInFile("WorkDate.txt", comboBox1.Text);
            setDate();
        }

        public void ReplaceInFile(string filePath, string searchText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, "");

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
