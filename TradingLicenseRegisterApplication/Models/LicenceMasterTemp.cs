using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Table("Licence_Master_Temp")]
    public partial class LicenceMasterTemp
    {
        [Key]
        [Column("tradeLicenceID")]
        public long TradeLicenceId { get; set; }
        [Required]
        [Column("applicantName")]
        [StringLength(128)]
        public string ApplicantName { get; set; }
        [Required]
        [Column("doorNumber")]
        [StringLength(16)]
        public string DoorNumber { get; set; }
        [Required]
        [Column("address1")]
        [StringLength(512)]
        public string Address1 { get; set; }
        [Required]
        [Column("address2")]
        [StringLength(512)]
        public string Address2 { get; set; }
        [Required]
        [Column("address3")]
        [StringLength(512)]
        public string Address3 { get; set; }
        [Column("pincode")]
        public int Pincode { get; set; }
        [Required]
        [Column("landLineNumber")]
        [StringLength(16)]
        public string LandLineNumber { get; set; }
        [Required]
        [Column("mobileNumber")]
        [StringLength(16)]
        public string MobileNumber { get; set; }
        [Required]
        [Column("emailID")]
        [StringLength(32)]
        public string EmailId { get; set; }
        [Required]
        [Column("tradeName")]
        [StringLength(512)]
        public string TradeName { get; set; }
        [Column("zonalClassificationID")]
        public int ZonalClassificationId { get; set; }
        [Column("mohID")]
        public int MohId { get; set; }
        [Column("wardID")]
        public int WardId { get; set; }
        [Column("PropertyID")]
        public int PropertyId { get; set; }
        [Required]
        [Column("PIDNumber")]
        [StringLength(75)]
        public string Pidnumber { get; set; }
        [Required]
        [Column("khathaNumber")]
        [StringLength(75)]
        public string KhathaNumber { get; set; }
        [Required]
        [Column("surveyNumber")]
        [StringLength(75)]
        public string SurveyNumber { get; set; }
        [Required]
        [Column("street")]
        [StringLength(512)]
        public string Street { get; set; }
        [Required]
        [Column("GISNumber")]
        [StringLength(16)]
        public string Gisnumber { get; set; }
        [Required]
        [Column("licenceNumber")]
        [StringLength(75)]
        public string LicenceNumber { get; set; }
        [Column("licenceCommencementDate", TypeName = "date")]
        public DateTime LicenceCommencementDate { get; set; }
        [Column("licenceStatusID")]
        public int LicenceStatusId { get; set; }
        [Column("oldapplicationNumber")]
        [StringLength(75)]
        public string OldapplicationNumber { get; set; }
        [Column("newlicenceNumber")]
        [StringLength(75)]
        public string NewlicenceNumber { get; set; }
    }
}
