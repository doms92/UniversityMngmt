using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityMngmt
{
    public partial class FormFinAccManager : Form
    {
        StudentContext context = new StudentContext();

        public FormFinAccManager()
        {
            InitializeComponent();

            // Shows list of student's account information when form loads
            Fill_ListView(context.StudentFinanceAccts.ToList());
        }

        /// <summary>
        /// Makes colmun names and width for ListView
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load_ListView();
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Account Name", 150);
            listView1.Columns.Add("Account Balance", 150);
            listView1.Columns.Add("Account Description", 175);
            
           
        }

        #region Button Click Section
        /// <summary>
        /// Adds a student from the textbox data when button is clicked
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) && string.IsNullOrWhiteSpace(txtBoxDesc.Text) && string.IsNullOrWhiteSpace(txtBoxBalance.Text.ToString()))
            {
                MessageBox.Show("Textboxes must have valid data. Please try again.");
            }
            else if (Save(txtBoxName.Text, Convert.ToInt32(txtBoxBalance.Text.ToString()), txtBoxDesc.Text))
            {
                txtBoxName.Text = "";
                txtBoxBalance.SelectedText = "";
                txtBoxDesc.Text = "";
            }
        }

       private void Edit()
        {
            listView1.SelectedItems[0].SubItems[1].Text = txtBoxName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtBoxBalance.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtBoxDesc.Text;

            //Clear Text
            txtBoxName.Text = "";
            txtBoxBalance.SelectedText = "";
            txtBoxDesc.Text = "";
        }
        
        /// <summary>
        /// Deletes Student Data already added when button is clicked
        /// </summary>
        /// 

        private void Delete()
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
        {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Student 1
            Delete();      
        }
        #endregion

        /// <summary>
        /// This method saves the information entered into the textboxes on form
        /// and enters the information into the database and populates the list on the form
        /// </summary>
        /// <param name="stuName">String variable that connects with AccountName</param>
        /// <param name="stuBalance">Int variable that connects with AccountBalance</param>
        /// <param name="stuDesc">String variable that connects with AccountDescription</param>
        /// <returns></returns>
        private Boolean Save(string stuName, int stuBalance, string stuDesc)
        {
            try
            {
                // Creates a new context if none it found
                if (context == null)
                {
                    context = new StudentContext();
                }

                // Makes a flexible student object to be entered into the database
                // Instead of multiple hard coded student data
                var studentFinanceObject = new StudentFinanceAcct()
                {
                    AccountName = stuName,
                    AccountBalance = stuBalance,
                    AccountDescription = stuDesc
                };

                context.StudentFinanceAccts.Add(studentFinanceObject);
                context.SaveChanges();

                Fill_ListView(context.StudentFinanceAccts.ToList());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Populates the form with proper student data (Shows the student in a list)
        /// </summary>
        public void Fill_ListView(List<StudentFinanceAcct> studentFinanceAccts)
        {
            // Clears list first and then shows list of student in detail
            listView1.Items.Clear();
            listView1.View = View.Details;

            // Adds each student data to the listview from String[] array
            foreach (var s in studentFinanceAccts)
            {
                String[] row = { Convert.ToString(s.AccountId), s.AccountName, Convert.ToString(s.AccountBalance), s.AccountDescription };

                listView1.Items.Add(new ListViewItem(row));
            }
        }

        /// <summary>
        /// Edit Student Data when Button is Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}