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
    public partial class 찾기 : Form
    {
        private 고용주 form2 = null;
        string filename;

        public 찾기(고용주 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.setEmployeeFIle(textBox1.Text);
            form2.dataBase();
            name();
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
                filename = textBox1.Text;
            }
        }

        public string name()
        {
            return filename;
        }
    }
}
