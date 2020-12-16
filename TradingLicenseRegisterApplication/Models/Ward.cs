using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Keyless]
    [Table("ward")]
    public partial class Ward
    {
        [Column("wardcd")]
        public int Wardcd { get; set; }
        [Column("wardname")]
        [StringLength(100)]
        public string Wardname { get; set; }
        [Column("wardnamek")]
        [StringLength(100)]
        public string Wardnamek { get; set; }
        [Column("mohcd")]
        public int? Mohcd { get; set; }
        [Column("mlccd")]
        public int? Mlccd { get; set; }
    }
}
