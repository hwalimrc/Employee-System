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
    public partial class 고용주 : Form
    {
        Division division = new Division();
        int buttonCount = 0;
        int num = 0;

        public 고용주()
        {
            InitializeComponent();
        }

        public 고용주(string FileName)
        {
            InitializeComponent();
            CompanyFile(FileName);
        }

        public void setCompany()
        {
            division.CompanyName = textBox46.Text;
            division.CompanyNumber = textBox47.Text;

            string savePath = textBox46.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(division.CompanyName + " ");
            sw.Write(division.CompanyNumber + " ");
            sw.Close();
        }

        public void setDivision()
        {
            division.DeptName = textBox48.Text;
            division.DeptPhone = textBox49.Text;
            division.DepMail = textBox50.Text;
            division.DeptAddInfo = textBox51.Text;
            division.DeptURL = textBox52.Text;

            string savePath = textBox36.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(division.DeptName + " ");
            sw.Write(division.DeptPhone + " ");
            sw.Write(division.DepMail + " ");
            sw.Write(division.DeptAddInfo + " ");
            sw.Write(division.DeptURL + " ");
            sw.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setCompany();
            setDivision();
            MessageBox.Show("입력완료"); num++;

            string savePath = "log.txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(textBox36.Text + " ");
            sw.Write(textBox37.Text + " ");
            sw.Close();
            FileWrite(textBox36.Text);
            clearCompany();
        }

        private void FileWrite(string str)
        {
            FileStream fs = new FileStream("CompanyNameDate.txt", FileMode.Append, FileAccess.Write);
            //FileMode중 append는 이어쓰기. 파일이 없으면 만든다.
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            찾기 openFile = new 찾기(this);
            openFile.Show();
        }

        public void setEmployeeFIle(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] textValue = line.Split(' ');
                textBox1.Text = textValue[0];
                textBox40.Text = textValue[0];
                textBox39.Text = textValue[1];
                textBox41.Text = textValue[2];
                textBox42.Text = textValue[3] + " " + textValue[4];
                textBox30.Text = textValue[6];
                textBox29.Text = textValue[8];
                textBox28.Text = textValue[9];
                textBox27.Text = textValue[10];
                textBox26.Text = textValue[11];
                textBox23.Text = textValue[12];
                textBox22.Text = textValue[13];
                textBox21.Text = textValue[14];
                textBox15.Text = textValue[15];
                textBox14.Text = textValue[16];
                textBox13.Text = textValue[17];
                textBox16.Text = textValue[18];
                textBox8.Text = textValue[19];
                textBox3.Text = textValue[20];
                textBox2.Text = textValue[21];
                textBox33.Text = textValue[22];
                textBox7.Text = textValue[23];
                textBox6.Text = textValue[24];
                textBox5.Text = textValue[25];
                textBox4.Text = textValue[26];
                textBox44.Text = textValue[27];
                textBox45.Text = textValue[28];
                textBox34.Text = textValue[29];
                textBox12.Text = textValue[30];
                textBox19.Text = textValue[31];
                textBox20.Text = textValue[32];
                textBox11.Text = textValue[33];
                textBox10.Text = textValue[34];
                textBox9.Text = textValue[35];
                textBox18.Text = textValue[36];
                textBox17.Text = textValue[37];

                if (textValue[5] == "남성") radioButton8.Checked = true;
                if (textValue[5] == "여성") radioButton7.Checked = true;

                if (textValue[7] == "기혼") radioButton4.Checked = true;
                if (textValue[7] == "미혼") radioButton3.Checked = true;

                System.Drawing.Bitmap bitmap = new Bitmap(textValue[38]);
                pictureBox1.Image = bitmap;
            }
            sr.Close();
        }

        public void ClearInfo()
        {
            textBox1.Clear();
            textBox40.Clear();
            textBox39.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox30.Clear();
            textBox29.Clear();
            textBox28.Clear();
            textBox27.Clear();
            textBox26.Clear();
            textBox23.Clear();
            textBox22.Clear();
            textBox21.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox16.Clear();
            textBox8.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox33.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox34.Clear();
            textBox12.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox18.Clear();
            textBox17.Clear();
        }

        public void clearCompany()
        {
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            근무일지_관리자용 diary = new 근무일지_관리자용(this);
            diary.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            회사찾기 openFile = new 회사찾기(this);
            openFile.Show();
        }

        public void dataBase()
        {
            string[] data1 = new string[3];
            string[] data2 = new string[3] { "0", "0", "0" };

            string filename = textBox39.Text + ".txt";

            data1[0] = textBox40.Text;
            data1[1] = textBox34.Text;
            data1[2] = textBox10.Text;
            dataGridView1.Rows.Add(data1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            회사찾기 openFile = new 회사찾기(this);
            openFile.Show();
        }

        public void CompanyFile(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] CompanytextValue = line.Split(' ');
                textBox46.Text = CompanytextValue[0];
                textBox47.Text = CompanytextValue[1];
                textBox48.Text = CompanytextValue[2];
                textBox49.Text = CompanytextValue[3];
                textBox50.Text = CompanytextValue[4];
                textBox51.Text = CompanytextValue[5];
                textBox52.Text = CompanytextValue[6];
            }
            sr.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FileInfo fileDel = new FileInfo(textBox36.Text + ".txt");
            if (fileDel.Exists) //삭제할 파일이 있는지
            {
                fileDel.Delete(); //없어도 에러안남
            }
            ReplaceInFile("Log.txt", textBox36.Text);
            clearCompany();
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

        private void button8_Click(object sender, EventArgs e)
        {
            FileInfo fileDel = new FileInfo(textBox39.Text + ".txt");
            if (fileDel.Exists) //삭제할 파일이 있는지
            {
                fileDel.Delete(); //없어도 에러안남
            }
            ReplaceInFile("Log.txt", textBox39.Text);
            ClearInfo();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            clearCompany();
            pictureBox1.Image = null;
            String file_path = null;

            openFileDialog1.InitialDirectory = "Debug";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                string filename = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                clearFile(filename);
                string rename = filename.Replace(".txt", "");
                textBox46.Text = rename;
            }
        }

        public void clearFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            StreamWriter sw = new StreamWriter(fileName, false);
            int countDelete = 0;

            if (countDelete == 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
                MessageBox.Show("수정 준비.");
            }
            else
            {
                for (int i = 0; i < countDelete; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                for (int i = countDelete + 1; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
                MessageBox.Show("수정 준비.");
            }
        }
    }
}
