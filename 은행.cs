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
    public partial class 은행 : Form
    {
        private EmployeeForm form1 = null;
        
        public 은행(EmployeeForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        string AcBank;
        string BankName;
        string SwiftCode;
        string Accocunt;

        private void button2_Click(object sender, EventArgs e)
        {
            AcBank = comboBox2.Text;
            if (AcBank == "국민은행")
            { BankName = "KOOK_MIN_BANK"; SwiftCode = "CZNBKRSE"; }

            if (AcBank == "기업은행")
            { BankName = "INDUSTRIAL_BANK_OF_KOREA"; SwiftCode = "IBKOKRSE"; }

            if (AcBank == "농협")
            { BankName = "INDUSTRIAL_AGRICULTURAL_COOPERATIVE_FEDERATION"; SwiftCode = "NACFKRSEXXX"; }

            if (AcBank == "신한은행")
            { BankName = "SHIN_HAN_BANK"; SwiftCode = "SHBKKRSE"; }

            if (AcBank == "우리은행")
            { BankName = "WOORI_BANK"; SwiftCode = "HVBKKRSE"; }

            if (AcBank == "하나은행")
            { BankName = "HANA_BANK"; SwiftCode = "KOEXKRSE"; }

            if (AcBank == "한국씨티은행")
            { BankName = "CITIBANK_KOREA"; SwiftCode = "CITIKRSX(WLS)"; }

            if (AcBank == "우체국")
            { BankName = "KOREA_POST_OFFICE"; SwiftCode = "KOPOKRS1"; }

            if (AcBank == "SC제일은행")
            { BankName = "STANDARD_CHARTERED_FIRST_BANK_KOREA"; SwiftCode = "SCBLKRSE"; }

            if (AcBank == "부산은행")
            { BankName = "BUSAN_BANK"; SwiftCode = "IBKOKRSE"; }

            if (AcBank == "대구은행")
            { BankName = "DEAGU_BANK"; SwiftCode = "DAEBKR22"; }

            if (AcBank == "경남은행")
            { BankName = "KYONGNAM_BANK"; SwiftCode = "KYNAKR22"; }

            if (AcBank == "광주은행")
            { BankName = "THE_KWANGJU_BANK.LTD"; SwiftCode = "KWABKRSE"; }
            Accocunt = textBox2.Text;
            form1.setBankData(AcBank, SwiftCode, Accocunt, BankName);
            Close();
        }
    }
}