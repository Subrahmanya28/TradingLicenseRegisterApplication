using FluentValidation;
using TradingLicenseRegisterApplication.Models;

namespace TradingLicenseRegisterApplication.Validators
{
    public class ClassificationValidator : AbstractValidator<TradeClassification>
    {
        public ClassificationValidator()
        {
            RuleFor(classification => classification.MajorTrade)
                .NotEmpty()
                .WithMessage("Major Trade is Required");
            RuleFor(classification => classification.MinorTrade)
                .NotEmpty()
                .WithMessage("Minor Trade is Required");
            RuleFor(classification => classification.SubTrade)
                .NotEmpty()
                .WithMessage("SubTrade is Required");
        }
    }
}