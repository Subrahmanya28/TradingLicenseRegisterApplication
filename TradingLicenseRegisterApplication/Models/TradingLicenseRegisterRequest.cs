using System;
using System.Collections.Generic;

namespace TradingLicenseRegisterApplication.Models
{
    public class TradingLicenseRegisterRequest
    {
        public string ApplicantRepresentingAs { get; set; }

        public string TradeType { get; set; }

        public string PropertyType { get; set; }

        public string TradeName { get; set; }

        public string ApplicantName { get; set; }

        public string Mobile { get; set; }

        public string Constituency { get; set; }

        public string Ward { get; set; }

        public string DoorNo { get; set; }

        public string Street { get; set; }

        public string Area { get; set; }

        public string PinCode { get; set; }

        public List<TradeClassification> TradeClassification { get; set; }

        public string Zone { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string ZoneClassification { get; set; }

        public double LicenseFee { get; set; }

        public string RoadWidthMoreThan40 { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public string TINNo { get; set; }

        public string BescomRRNo { get; set; }

        public DateTime ProposedDateOfTrade { get; set; }
    }
}