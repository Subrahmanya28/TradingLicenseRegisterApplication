using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Keyless]
    [Table("MLC")]
    public partial class Mlc
    {
        [Column("mlccd")]
        public int Mlccd { get; set; }
        [Column("mlcname")]
        [StringLength(100)]
        public string Mlcname { get; set; }
    }
}
