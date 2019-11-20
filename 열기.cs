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
    public partial class 열기 : Form
    {
        private EmployeeForm form1 = null;

        public 열기(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.setFIle(textBox1.Text);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String file_path = null;
            openFileDialog1.InitialDirectory = "Debug";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
            }
        }
    }
}
