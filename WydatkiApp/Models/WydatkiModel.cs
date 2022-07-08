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
    [Table("wydatki")]
    public class WydatkiModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("User Id")]
        public int UserId { get; set; }
        [DisplayName("Saldo")]
        public int Amount { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
    }
}
