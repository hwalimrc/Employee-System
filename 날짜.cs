using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class 날짜 : Form
    {
        private EmployeeForm form1 = null;
        public string date1, date2;

        public 날짜(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1 = monthCalendar1.SelectionStart.ToShortDateString();
            textBox1.Text = date1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                form1.setDate(date1, "재직중");
            if (radioButton2.Checked)
                form1.setDate(date1, date2);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date2 = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox2.Text = date2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false; textBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true; textBox2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void groupBox1_Enter(object sender, EventArgs e)
        { }        
    }
}
