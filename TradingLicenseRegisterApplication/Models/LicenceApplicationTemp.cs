using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TradingLicenseRegisterApplication.Models
{
    [Table("Licence_Application_Temp")]
    public partial class LicenceApplicationTemp
    {
        [Key]
        [Column("licenceApplicationID")]
        public long LicenceApplicationId { get; set; }
        [Column("newApplicationNumber")]
        [StringLength(75)]
        public string NewApplicationNumber { get; set; }
        [Column("finanicalYearID")]
        public int? FinanicalYearId { get; set; }
        [Column("tradeTypeID")]
        public int TradeTypeId { get; set; }
        [Required]
        [Column("bescomRRNumber")]
        [StringLength(32)]
        public string BescomRrnumber { get; set; }
        [Required]
        [Column("TINNumber")]
        [StringLength(32)]
        public string Tinnumber { get; set; }
        [Required]
        [Column("VATNumber")]
        [StringLength(32)]
        public string Vatnumber { get; set; }
        [Column("applicationSubmitDate", TypeName = "datetime")]
        public DateTime ApplicationSubmitDate { get; set; }
        [Column("applicationEntryDate", TypeName = "datetime")]
        public DateTime ApplicationEntryDate { get; set; }
        [Required]
        [Column("acknowledgementNumber")]
        [StringLength(64)]
        public string AcknowledgementNumber { get; set; }
        [Column("acknowledgementDate", TypeName = "datetime")]
        public DateTime? AcknowledgementDate { get; set; }
        [Column("acknowledgementSecurityCode")]
        [StringLength(256)]
        public string AcknowledgementSecurityCode { get; set; }
        [Column("receiptNumber")]
        [StringLength(32)]
        public string ReceiptNumber { get; set; }
        [Column("receiptDate", TypeName = "datetime")]
        public DateTime ReceiptDate { get; set; }
        [Column("receiptSecurityCode")]
        [StringLength(256)]
        public string ReceiptSecurityCode { get; set; }
        [Column("licenceFromDate", TypeName = "date")]
        public DateTime LicenceFromDate { get; set; }
        [Column("licenceToDate", TypeName = "date")]
        public DateTime LicenceToDate { get; set; }
        [Column("licenceApplicationStatusID")]
        public int LicenceApplicationStatusId { get; set; }
        [Column("currentStatus")]
        public int? CurrentStatus { get; set; }
        [Column("tradeLicenceID")]
        public long TradeLicenceId { get; set; }
        [Column("mohID")]
        public int MohId { get; set; }
        [Column("loginID")]
        public int LoginId { get; set; }
        [Column("entryOriginLoginID")]
        public int? EntryOriginLoginId { get; set; }
        [Column("isActive")]
        [StringLength(1)]
        public string IsActive { get; set; }
        [StringLength(256)]
        public string InactiveReason { get; set; }
        [Column("InspectingOfficerID")]
        public int? InspectingOfficerId { get; set; }
        [Column("licenseType")]
        public short? LicenseType { get; set; }
        public int? ApplicantRepersenting { get; set; }
        [Column("applicationNumber")]
        [StringLength(50)]
        public string ApplicationNumber { get; set; }
        [Column("docsSubmitted")]
        [StringLength(25)]
        public string DocsSubmitted { get; set; }
        [Column("jathaStatus")]
        public int? JathaStatus { get; set; }
        public int? ChallanNo { get; set; }
        public int? NoOfYearsApplied { get; set; }
    }
}
