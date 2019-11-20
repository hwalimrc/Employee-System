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
    public partial class 사용자 : Form
    {
        public 사용자()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 고용주 폼으로 접속
            고용주 Presldent = new 고용주();
            Presldent.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            Close();
        }
    }
}
