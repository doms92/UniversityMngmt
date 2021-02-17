using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMngmt
{
    public static class StudentFinanceAcctDB
    {
        /// <summary>
        /// Returns a list of all financial accounts,
        /// sorted by AccountId, in ascending order.
        /// </summary>
        public static List<StudentFinanceAcct> GetAllStudents() 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a Student's financial account to the DB
        /// </summary>
        public static StudentFinanceAcct Add(StudentFinanceAcct acct)
        {
            using (var context = new StudentContext())
            {
                context.StudentFinanceAccts.Add(acct);
                context.SaveChanges();

                return acct;
            }
        }

        /// <summary>
        /// Updates/Edits all financial account data on student's account
        /// </summary>
        public static StudentFinanceAcct Update(StudentFinanceAcct acct)
        {
            using(var context = new StudentContext()) 
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(acct).State = EntityState.Modified;
                context.SaveChanges();

                return acct;
            }
        }

        public static void Delete(StudentFinanceAcct acct)
        {
            using(var context = new StudentContext())
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(acct).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes student financial account from DB
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id) 
        {
            using(var context = new StudentContext())
            {
                StudentFinanceAcct stuToDelete =
                    (from p in context.StudentFinanceAccts
                     where p.AccountId == id
                     select p).Single();

                context.Entry(stuToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}