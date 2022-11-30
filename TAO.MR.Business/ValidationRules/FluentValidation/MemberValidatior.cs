using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Entities.Concrete;
using TAO_Core.Aspects.Autofac.Validation;

namespace TAO.MR.Business.ValidationRules.FluentValidation
{
  public class MemberValidatior: AbstractValidator<Member>
  {
    public MemberValidatior()
    {
      #region NotEmptyRules

      RuleFor(m => m.FirstName).NotEmpty();
      RuleFor(m => m.LastName).NotEmpty();
      RuleFor(m => m.NationalIdentity).NotEmpty();
      RuleFor(m => m.DateOfBirth).NotEmpty();
      RuleFor(m => m.Email).NotEmpty();

      #endregion

      RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now);
      RuleFor(m => m.Email).EmailAddress();
      RuleFor(m => m.NationalIdentity).Length(11); //Because TCKN length should be 11

    }
  }
}
