using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    class Personal
    {
        public string State, City, Street, Zip;
        public string Home, Phone1, Phone2, Phone3;
        public string PersonalEmail, mainEmail;
        public string Picture;

        public string HiredDate;
        public string ResignDate;
        public string Division, Department, Title, Classification, ContractNo, EmploymentStatus, EmploymentWorkout;

        public string Name;
        public string NicName;
        public string Birth, Place;
        public string Gender, Nationality;
        public string MaritalStatus;
        public string Spouse1, Spouse2, Children1, Children2;
        public string Facebook, Twiter, Kakao;
        public string BankName, Bank, SwiftCode, Account;
    }

    class Company
    {
        public string CompanyName;
        public string CompanyNumber;
    }

    class Division : Company
    {
        public string DeptName;
        public string DeptPhone;
        public string DepMail;
        public string DeptAddInfo;
        public string DeptURL;
    }

    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
