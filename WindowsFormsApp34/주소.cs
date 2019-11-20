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
    public partial class 주소 : Form
    {
        private EmployeeForm form1 = null;

        public 주소(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string place = textBox1.Text;
            string city = textBox2.Text;

            StringBuilder add = new StringBuilder("https://www.google.com/maps/@36.7623313,126.9436552,15z");

            add.Append(place);
            add.Append(city);

            webBrowser1.Navigate(add.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.setPlaceData(textBox1.Text, textBox2.Text);
            Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
