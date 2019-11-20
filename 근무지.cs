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
    public partial class 근무지 : Form
    {
        private EmployeeForm form1 = null;

        public 근무지(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        string place;

        private void selectPlace()
        {
            if (radioButton1.Checked)
                place = "멀티미디어관";
            else if (radioButton2.Checked)
                place = "학예관";
            else if (radioButton3.Checked)
                place = "공과대학";
            else if (radioButton4.Checked)
                place = "중앙도서관";
            else if (radioButton5.Checked)
                place = "대학본부";
            else if (radioButton6.Checked)
                place = "인문과학대학";
            else if (radioButton7.Checked)
                place = "자연과학대학";
            else if (radioButton8.Checked)
                place = "은행";
            else if (radioButton9.Checked)
                place = "교육대학";
            else if (radioButton10.Checked)
                place = "의과대학";
            else if (radioButton11.Checked)
                place = "체육대학";
            else if (radioButton12.Checked)
                place = "SCH미디어랩스";
            else if (radioButton13.Checked)
                place = "산악협력관";
            else if (radioButton14.Checked)
                place = "앙뜨레프레너쉽";
            else if (radioButton15.Checked)
                place = "유니토피아관";
            else if (radioButton16.Checked)
                place = "학군단";
            else
                place = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPlace();
            textBox1.Text = place;
            form1.setPlaced(textBox1.Text);
        }

        private void 근무지_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
