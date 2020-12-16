using FluentValidation;
using TradingLicenseRegisterApplication.Models;

namespace TradingLicenseRegisterApplication.Validators
{
    public class TradingLicenseRegisterRequestValidator : AbstractValidator<TradingLicenseRegisterRequest>
    {
        public TradingLicenseRegisterRequestValidator()
        {
            RuleFor(request => request.ApplicantRepresentingAs)
                .NotNull()
                .NotEmpty()
                .WithMessage("ApplicantRepresentingAs Name is required");

            RuleFor(request => request.TradeType)
                .NotNull()
                .NotEmpty()
                .WithMessage("Trade Type is required");

            RuleFor(request => request.PropertyType)
                .NotNull()
                .NotEmpty()
                .WithMessage("Property Type is required");

            RuleFor(request => request.TradeName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Trade Name is required");

            RuleFor(request => request.ApplicantName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Applicant Name is required");

            RuleFor(request => request.Mobile)
                .NotNull()
                .NotEmpty()
                .WithMessage("Mobile Number is required");

            RuleFor(request => request.Mobile)
                .MaximumLength(10)
                .WithMessage("Invalid Mobile number");

            RuleFor(request => request.Constituency)
                .NotNull()
                .NotEmpty()
                .WithMessage("MLC Constituency is required");

            RuleFor(request => request.Ward)
                .NotNull()
                .NotEmpty()
                .WithMessage("Ward is required");

            RuleFor(request => request.Constituency)
                .NotNull()
                .NotEmpty()
                .WithMessage("MLC Constituency is required");

            RuleFor(request => request.DoorNo)
                .NotNull()
                .NotEmpty()
                .WithMessage("Door number is required");

            RuleFor(request => request.Street)
                .NotNull()
                .NotEmpty()
                .WithMessage("Street is required");

            RuleFor(request => request.Area)
                .NotNull()
                .NotEmpty()
                .WithMessage("Area is required");

            RuleFor(request => request.Email)
                .NotNull()
                .NotEmpty()
                .WithMessage("Email is required");

            RuleFor(request => request.Email)
                .EmailAddress()
                .WithMessage("Invalid Email");
           
            RuleFor(request => request.ProposedDateOfTrade)
                .NotNull()
                .WithMessage("Trade Proposed Date is required");

            RuleFor(request => request.PinCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Pin Code is required");

            RuleFor(request => request.Zone)
                .NotNull()
                .NotEmpty()
                .WithMessage("Zone is required");

            RuleFor(request => request.ZoneClassification)
                .NotNull()
                .NotEmpty()
                .WithMessage("Zone Classification is required");

            RuleFor(request => request.LicenseFee)
                .GreaterThan(0.0)
                .WithMessage("License fee should be greater than 0");

            RuleFor(request => request.RoadWidthMoreThan40)
                .NotNull()
                .NotEmpty()
                .WithMessage("Is Road width more than 40 is required");

            RuleFor(request => request.ApplicationDate)
                .NotNull()
                .WithMessage("Date of Application is required");

            RuleFor(request => request.TradeClassification)
                .Must(list => list.Count >= 1)
                .WithMessage("Trade classifications are required at least one")
                .When(request => request.TradeClassification != null);

            RuleForEach(request => request.TradeClassification)
                .SetValidator(new ClassificationValidator())
                .When(request => request.TradeClassification != null);
        }
    }
}