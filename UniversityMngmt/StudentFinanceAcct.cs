using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMngmt
{
   public class StudentFinanceAcct
    {
        /// <summary>
        /// Individual student account that holds student financial information
        /// </summary>
        /// <param name="AccID">The student's account ID</param>
        /// <param name="AccName">The student's account name</param>
        /// <param name="AccDesc"> The account description</param>
        /// <param name="AccBal">The student's account balance</param>
        public StudentFinanceAcct(int AccID, string AccName, string AccDesc, decimal AccBal)
        {
            AccountId = AccID;
            AccountName = AccName;
            AccountDescription = AccDesc;
            AccountBalance = AccBal;
        }

        /// <summary>
        /// Financial Account Identification Number, Primary Key
        /// </summary>
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the financial account
        /// </summary> 
        /// 
        [Required]
        public string AccountName { get; set; }

        /// <summary>
        /// The account description
        /// </summary>
        public string AccountDescription { get; set; }

        /// <summary>
        /// The account balance, how much money is due
        /// </summary>
        public decimal AccountBalance { get; private set; }
    }
}