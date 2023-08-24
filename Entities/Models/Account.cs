using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("account")]
   public class Account
    {
        public int AccountId { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Createddate { get; set; }
        [Required(ErrorMessage ="Account type is required")]
        public string Accounttype { get; set; }

        [ForeignKey (nameof(User))]
        public User User { get; set; }
        public Guid UserId { get; set; }


    }
}
