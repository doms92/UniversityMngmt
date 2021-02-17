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

            StudentFinanceAcctDB.Add(s1);

            StudentFinanceAcctDB.Delete(s1);

            // Student 2
        }
    }
}
