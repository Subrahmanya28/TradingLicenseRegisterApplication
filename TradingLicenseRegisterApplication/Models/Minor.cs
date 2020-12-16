using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Keyless]
    [Table("minor")]
    public partial class Minor
    {
        [Column("majorcd")]
        public int Majorcd { get; set; }
        [Column("minorcd")]
        public int Minorcd { get; set; }
        [Column("minorname")]
        [StringLength(255)]
        public string Minorname { get; set; }
        [Column("minornamek")]
        [StringLength(255)]
        public string Minornamek { get; set; }
    }
}
