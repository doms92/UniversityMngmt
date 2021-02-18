using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityMngmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Student 1
            var s1 = new StudentFinanceAcct()
            {
                AccountName = "Alice Jones",
                AccountBalance = 1300,
                AccountDescription = "Balance due"
            };

            // Adds new student object
            StudentFinanceAcctDB.Add(s1);

            // Updates information in Student db
            s1.AccountBalance = 0;
            s1.AccountDescription = "Balance paid in full";
            StudentFinanceAcctDB.Update(s1);

            // Deletes student from Student db
            StudentFinanceAcctDB.Delete(s1);

            // Student 2
            var s2 = new StudentFinanceAcct()
            {
                AccountName = "Bruce Wayne",
                AccountDescription = "Balance due",
                AccountBalance = 3300
            };
            // Adds new student object
            StudentFinanceAcctDB.Add(s2);

            // Updates information in Student db
            s2.AccountBalance = 1000;
            s2.AccountDescription = "Balance overdue";
            StudentFinanceAcctDB.Update(s2);

            // Deletes student from Student db
            StudentFinanceAcctDB.Delete(s2);

            // Gets All Student Accts From Student db
            List<StudentFinanceAcct> accts = StudentFinanceAcctDB.GetAllStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
