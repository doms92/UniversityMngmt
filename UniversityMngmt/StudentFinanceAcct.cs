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
        /// Financial Account Identification Number, Primary Key
        /// </summary>
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the student's financial account
        /// </summary> 
        [Required]
        public string AccountName { get; set; }

        /// <summary>
        /// The account description
        /// </summary>
        public string AccountDescription { get; set; }

        /// <summary>
        /// The account balance, how much money is due
        /// </summary>
        public decimal AccountBalance { get; set; }
    }
}