using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("user")]
   public class User
    {
        public Guid UserId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(40,ErrorMessage ="Name shouldn't be more than 40 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="DateofBirth is required")]
        public DateTime Dateofbirth { get; set; }
        [Required(ErrorMessage ="Address is required")]
        [StringLength(100,ErrorMessage = "Address shouldn't be more than 100 characters ")]
        public string Address { get; set; }

        public ICollection <Account> Accounts { get; set; }



    }
}
