using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WydatkiApp.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Hasło")]
        public string Password { get; set; }
        [DisplayName("Saldo")]
        public int Money { get; set; }

    }
}
