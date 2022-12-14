using KpsServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Business.Abstract;
using TAO.MR.Business.Constants;
using TAO.MR.Business.ServiceAdapters;
using TAO.MR.Business.ValidationRules.FluentValidation;
using TAO.MR.DataAccess.Abstract;
using TAO.MR.Entities.Concrete;
using TAO_Core.Aspects.Autofac.Validation;
using TAO_Core.Utilities.Business;
using TAO_Core.Utilities.Results;
using TAO_Core.Utilities.Results.Concrete;

namespace TAO.MR.Business.Concrete
{
  public class MemberManager :IMemberService
  {
    IMemberDal _memberDal;
    IKpsService _kpsService;
    public MemberManager(IMemberDal memberDal,IKpsService kpsService)
    {
      _memberDal = memberDal;
      _kpsService = kpsService; 
    }
    [ValidationAspect(typeof(MemberValidatior))]
    public IResult Add(Member member)
    {
      var result = BusinessRules.Run(CheckIfMemberExists(member),
                                     CheckIfMemberValidFromKPS(member));
      if(result != null)
      {
        return result;
      }
      
      _memberDal.Add(member);
      return new SuccessResult(Messages.MemberAdded);
    }
    private IResult CheckIfMemberExists(Member member)
    {
      if(_memberDal.Get(m=>m.NationalIdentity == member.NationalIdentity) != null)
      {
        return new ErrorResult(Messages.MemberAlreadyExists);
      }
      return new SuccessResult();
    }
    private IResult CheckIfMemberValidFromKPS(Member member)
    {
      if (_kpsService.ValidateUser(member) == false)
      {
        return new ErrorResult(Messages.MemberNotValid);
      }
      return new SuccessResult();
    }
  }
}
