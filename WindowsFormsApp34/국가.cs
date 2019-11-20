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
    public partial class 국가 : Form
    {
        private EmployeeForm form1 = null;

        public 국가(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        string zip, zipCode;

        private void button1_Click(object sender, EventArgs e)
        {
            zip = comboBox1.Text;
            if (zip == "한국")
                zipCode = "82";
            if (zip == "미국")
                zipCode = "1";
            if (zip == "일본")
                zipCode = "81";
            if (zip == "중국")
                zipCode = "86";
            form1.setZipCode(zipCode);
            Close();
        }
    }
}
