using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserOperationClaimValidator : AbstractValidator<UserOperationClaim>
    {
        public UserOperationClaimValidator()
        {
            RuleFor(u => u.DetailId).NotEmpty();
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.ClaimId).NotEmpty();
        }
    }
}
