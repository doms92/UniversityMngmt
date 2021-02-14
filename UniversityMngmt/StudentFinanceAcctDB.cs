using System;
using System.Collections.Generic;
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
        public static List<StudentAccount>
        using (var context = new StudentContext())
    {
        List<StudentFinanceAcct> acc = (from fa in StudentAccount
                                    orderby fa.AccountId ascending
                                    select fa).ToList();

        return acc;
        }
    }
/// <summary>
/// Adds A Student Financial account to the DB
/// </summary>

public static StudentFinanceAcct Add(StudentFinanceAcct acct)
{
    using (var context = new StudentContext())
    {
        context.StudentFinanceAcct.Add(acct);
        context.SaveChanges();
    }
    return acct;
}

/// <summary>
/// Updates/Edits all Financial Account data
/// </summary>
public static StudentFinanceAcct Update(StudentFinanceAcct acct)
{
    
}
 /// <summary>
 /// Deletes a financial account from the DB
 /// </summary>
public static void Delete(StudentFinanceAcct)

