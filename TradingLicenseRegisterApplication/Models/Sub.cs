using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Keyless]
    [Table("sub")]
    public partial class Sub
    {
        [Column("majorcd")]
        public int Majorcd { get; set; }
        [Column("minorcd")]
        public int Minorcd { get; set; }
        [Column("subcd")]
        public int Subcd { get; set; }
        [Column("subname")]
        [StringLength(255)]
        public string Subname { get; set; }
        [Column("subnamek")]
        [StringLength(255)]
        public string Subnamek { get; set; }
        [Column("sublicfee")]
        public int? Sublicfee { get; set; }
        [Column("Aprove_Auth")]
        public int? AproveAuth { get; set; }
    }
}
