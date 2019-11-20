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
    public partial class 회사찾기 : Form
    {
        private 고용주 form2 = null;

        public 회사찾기(고용주 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void 회사찾기_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String file_path = null;
            openFileDialog1.InitialDirectory = "Debug";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.CompanyFile(textBox1.Text);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 public partial class 찾기 : Form
    {
        private 고용주 form2 = null;

        public 찾기(고용주 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.setEmployeeFIle(textBox1.Text);
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            String file_path = null;
            openFileDialog1.InitialDirectory = "Debug";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
            }
        }
    }
 */