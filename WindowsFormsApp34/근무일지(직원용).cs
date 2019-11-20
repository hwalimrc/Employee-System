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
    public partial class 근무일지_직원용_ : Form
    {
        private 일지 form1 = null;
        public string date1, date2, time1, time2;

        public 근무일지_직원용_(일지 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox3.Text + ".txt");
            setTime();
            sw.Write(textBox1.Text+ " ");
            sw.Write(time1 + " ");
            sw.Write(comboBox1.Text + " ");
            sw.Write(textBox2.Text + " ");
            sw.Write(time2 + " ");
            sw.Write(comboBox2.Text + " ");
            sw.Close();
            MessageBox.Show("근무 내역이 입력되었습니다");
            FileWrite(textBox3.Text + " ");
            form1.setDate();
            Close();
        }

        private void FileWrite(string str)
        {
            FileStream fs = new FileStream("WorkDate.txt", FileMode.Append, FileAccess.Write);
            //FileMode중 append는 이어쓰기. 파일이 없으면 만든다.
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void setTime()
        {
            if (radioButton1.Checked == true)
                time1 = "오전";
            if (radioButton2.Checked == true)
                time1 = "오후";
            if (radioButton3.Checked == true)
                time2 = "오전";
            if (radioButton4.Checked == true)
                time2 = "오후";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date2 = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox2.Text = date2;
        }

        private void 근무일지_직원용__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1 = monthCalendar1.SelectionStart.ToShortDateString();
            textBox1.Text = date1;
        }
    }
}
