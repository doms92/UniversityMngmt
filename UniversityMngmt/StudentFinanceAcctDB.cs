using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMngmt
{
   public static class StudentAccountDB
    {
        public static List<StudentAccount>
        using (var context = new StudentContext())
    {
        List<StudentAccount> acc = (from fa in StudentAccount
                                    orderby fa.AccountId ascending
                                    select fa).ToList();

        }
    }

