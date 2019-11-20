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
    public partial class EmployeeForm : Form
    {
        Personal personal = new Personal();
        int buttonCount = 0;
        int num = 0;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(string FileName)
        {
            InitializeComponent();
            setFIle(FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            은행 bankForm = new 은행(this);
            bankForm.Show();
        }

        public void setBankData(string acbank, string swift, string account, string acname)
        {
            textBox15.Text = acbank;
            textBox14.Text = swift;
            textBox13.Text = account;
            textBox16.Text = acname;

            personal.BankName = acname;
            personal.Bank = acbank;
            personal.SwiftCode = swift;
            personal.Account = account;
        }

        public void setPlaceData(string state, string city)
        {
            textBox32.Text = state + " " + city;
        }

        public void setZipCode(string zipcode)
        {
            textBox33.Text = zipcode;
        }

        public void setPlaced(string place)
        {
            textBox9.Text = place;
        }

        public void setDate(string date1, string date2)
        {
            textBox18.Text = date1;
            textBox17.Text = date2;
            personal.HiredDate = textBox18.Text;
            personal.ResignDate = textBox17.Text;
        }

        public void checkMerried()
        {
            if(radioButton4.Checked) // 기혼
                personal.MaritalStatus = "기혼"; 
            if(radioButton3.Checked) // 미혼
                personal.MaritalStatus = "미혼";
        }

        public void checkGender()
        {
            if (radioButton7.Checked) // 여성
                personal.Gender = "여성";
            if (radioButton8.Checked) // 남성
                personal.Gender = "남성";
        }

        public void setName()
        {
            personal.Name = textBox25.Text;
            personal.NicName = textBox24.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Name + " ");
            sw.Write(personal.NicName + " ");
            //sw.Flush();
            sw.Close();
        }

        public void setPlaceandBirth()
        {
            personal.Place = textBox31.Text;
            personal.Birth = textBox32.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Place + " ");
            sw.Write(personal.Birth + " ");
            sw.Close();
        }

        public void setGendeNationalityGender()
        {
            checkGender();
            personal.Nationality = textBox30.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Gender + " ");
            sw.Write(personal.Nationality + " ");
            sw.Close();
        }

        public void setFamily()
        {
            checkMerried();
            personal.Spouse1 = textBox29.Text;
            setChildren();

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.MaritalStatus + " ");
            sw.Write(personal.Spouse1 + " ");
            sw.Write(personal.Spouse2 + " ");
            sw.Write(personal.Children1 + " ");
            sw.Write(personal.Children2 + " ");
            sw.Close();
        }

        public void setChildren()
        {
            if (textBox26.Visible == false)
                personal.Spouse2 = "자녀없음";
            else
                personal.Spouse2 = textBox28.Text;

            if (textBox27.Visible == false)
                personal.Children1 = "자녀없음";
            else
                personal.Children1 = textBox27.Text;

            if(textBox28.Visible == false)
                personal.Children2 = "자녀없음";
            else
                personal.Children2 = textBox26.Text;
        }

        public void setPhone()
        {
            if (textBox5.Visible == false)
                personal.Phone2 = "추가휴대폰없음";
            else
                personal.Phone2 = textBox5.Text;

            if (textBox4.Visible == false)
                personal.Phone3 = "추가휴대폰없음";
            else
                personal.Phone3 = textBox4.Text;
        }

        public void setSNS()
        {
            personal.Facebook = textBox23.Text;
            personal.Twiter = textBox22.Text;
            personal.Kakao = textBox21.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Facebook + " ");
            sw.Write(personal.Twiter + " ");
            sw.Write(personal.Kakao + " ");
            sw.Close();
        }

        public void setAccount()
        {
            personal.Bank = textBox15.Text;
            personal.SwiftCode = textBox14.Text;
            personal.Account = textBox13.Text;
            personal.BankName = textBox16.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Bank + " ");
            sw.Write(personal.SwiftCode + " ");
            sw.Write(personal.Account + " ");
            sw.Write(personal.BankName + " ");
            sw.Close();
        }

        public void setAddress()
        {
            personal.State = textBox3.Text;
            personal.City = textBox2.Text;
            personal.Street = textBox1.Text;
            personal.Zip = textBox33.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.State + " ");
            sw.Write(personal.City + " ");
            sw.Write(personal.Street + " ");
            sw.Write(personal.Zip + " ");
            sw.Close();
        }

        public void setPhoneNumber()
        {
            personal.Home = textBox7.Text;
            personal.Phone1 = textBox6.Text;
            if (textBox5.Visible == true)
            {
                if (textBox5.Text.Length == 11)
                    personal.Phone2 = textBox5.Text;
                else MessageBox.Show("올바르지 않은 입력입니다 -a");
            }

            if (textBox4.Visible == true)
            {
                if (textBox4.Text.Length == 11)
                    personal.Phone3 = textBox4.Text;
                else MessageBox.Show("올바르지 않은 입력입니다 -b");
            }

            setPhone();

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Home + " ");
            sw.Write(personal.Phone1 + " ");
            sw.Write(personal.Phone2 + " ");
            sw.Write(personal.Phone3 + " ");
            sw.Close();
        }

        public void setEmail()
        {
            personal.PersonalEmail = textBox44.Text;
            personal.mainEmail = textBox45.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.PersonalEmail + " ");
            sw.Write(personal.mainEmail + " ");
            sw.Close();
        }

        public void setPosition()
        {
            personal.Division = textBox12.Text;
            personal.Department = textBox11.Text;
            personal.Title = textBox19.Text;
            personal.Classification = textBox20.Text;
            personal.ContractNo = textBox10.Text;
            personal.EmploymentStatus = textBox9.Text;
            personal.EmploymentWorkout = textBox8.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.Division + " ");
            sw.Write(personal.Department + " ");
            sw.Write(personal.Title + " ");
            sw.Write(personal.Classification + " ");
            sw.Write(personal.ContractNo + " ");
            sw.Write(personal.EmploymentStatus + " ");
            sw.Write(personal.EmploymentWorkout + " ");
            sw.Close();
        }

        public void setHiredDate()
        {
            personal.HiredDate = textBox18.Text;
            personal.ResignDate = textBox17.Text;

            string savePath = textBox24.Text + ".txt";
            FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(personal.HiredDate + " ");
            sw.Write(personal.ResignDate + " ");
            sw.Write(personal.Picture + " ");
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            주소 place = new 주소(this);
            place.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonCount++;
            if (buttonCount == 1) textBox28.Visible = true;
            if (buttonCount == 2) textBox27.Visible = true;
            if (buttonCount == 3) textBox26.Visible = true;
            if (buttonCount > 4) buttonCount = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonCount++;
            if (buttonCount == 1) textBox5.Visible = true;
            if (buttonCount == 2) textBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            국가 zipForm = new 국가(this);
            zipForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string Path = open.FileName;
            Bitmap bitmap = new Bitmap(Path);
            pictureBox1.Image = bitmap;
            personal.Picture = Path;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            날짜 data = new 날짜(this);
            data.Show();
        }

        public bool ortherCheck()
        {
            if (textBox32.Text.Length != 7)
            {
                MessageBox.Show("올바르지 않은 입력입니다 - 주민번호");
                return false;
            }
            else if (textBox7.Text.Length != 10)
            {
                MessageBox.Show("올바르지 않은 입력입니다 - 자택번호");
                return false;
            }
            else if (textBox6.Text.Length != 11)
            {
                MessageBox.Show("올바르지 않은 입력입니다 - 휴대전화번호");
                return false;
            }

            if (textBox44.Text.Contains("@") == false || textBox45.Text.Contains("@") == false)
            {
                MessageBox.Show("올바르지 않은 입력입니다 - 메일주소");
                return false;
            }
            else return true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))   //숫자를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ortherCheck() == true)
            {
                checkGender();
                checkMerried();
                setName();
                setPlaceandBirth();
                setGendeNationalityGender();
                setFamily();
                setSNS();
                setAccount();
                setAddress();
                setPhoneNumber();
                setEmail();
                setPosition();
                setHiredDate();

                string savePath = "Log.txt";
                FileStream fs = new FileStream(savePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(textBox24.Text + " ");
                sw.Write(textBox31.Text + " ");
                sw.Close();
                FileWrite(textBox25.Text);
            }
            pictureBox1.Image = null;
            ClearInfo();
        }

        private void FileWrite(string str)
        {
            FileStream fs = new FileStream("NameDate.txt", FileMode.Append, FileAccess.Write);
            //FileMode중 append는 이어쓰기. 파일이 없으면 만든다.
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearInfo();
            열기 openFile = new 열기(this);
            openFile.Show();
        }

        public void setFIle(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] textValue = line.Split(' ');
                textBox25.Text = textValue[0];
                textBox24.Text = textValue[1];
                textBox31.Text = textValue[2];
                textBox32.Text = textValue[3] + " " + textValue[4];
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
                textBox3.Text = textValue[19];
                textBox2.Text = textValue[20];
                textBox1.Text = textValue[21];
                textBox33.Text = textValue[22];
                textBox7.Text = textValue[23];
                textBox6.Text = textValue[24];
                textBox5.Text = textValue[25];
                textBox4.Text = textValue[26];
                textBox44.Text = textValue[27];
                textBox45.Text = textValue[28];
                textBox12.Text = textValue[29];
                textBox11.Text = textValue[30];
                textBox19.Text = textValue[31];
                textBox20.Text = textValue[32];
                textBox10.Text = textValue[33];
                textBox9.Text = textValue[34];
                textBox8.Text = textValue[35];
                textBox18.Text = textValue[36];
                textBox17.Text = textValue[37];

                if (textValue[5] == "남성") radioButton8.Checked = true;
                if (textValue[5] == "여성") radioButton7.Checked = true;

                if (textValue[7] == "기혼") radioButton4.Checked = true;
                if (textValue[7] == "미혼") radioButton3.Checked = true;

                Bitmap bitmap = new Bitmap(textValue[38]);
                pictureBox1.Image = bitmap;
            }
            sr.Close();
        }

        public void ClearInfo()
        {
            textBox25.Clear();
            textBox24.Clear();
            textBox31.Clear();
            textBox32.Clear();
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
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox33.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox18.Clear();
            textBox17.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            근무지 place = new 근무지(this);
            place.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        { }

        private void button3_Click(object sender, EventArgs e)
        {
            일지 diary = new 일지(this);
            diary.Show();
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

        private void button13_Click(object sender, EventArgs e)
        {
            ClearInfo();
            pictureBox1.Image = null;
            String file_path = null;

            openFileDialog1.InitialDirectory = "Debug";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                string filename = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                clearFile(filename);
                string rename = filename.Replace(".txt", "");
                textBox24.Text = rename;
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

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
