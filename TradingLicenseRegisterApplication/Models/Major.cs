using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Keyless]
    [Table("Major")]
    public partial class Major
    {
        [Column("majorcd")]
        public int Majorcd { get; set; }
        [Column("majorname")]
        [StringLength(255)]
        public string Majorname { get; set; }
        [Column("majornamek")]
        [StringLength(255)]
        public string Majornamek { get; set; }
    }
}
