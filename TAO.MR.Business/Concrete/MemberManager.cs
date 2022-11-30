using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Business.Abstract;
using TAO.MR.DataAccess.Abstract;
using TAO.MR.Entities.Concrete;
using TAO_Core.Utilities.Results;

namespace TAO.MR.Business.Concrete
{
  public class MemberManager :IMemberService
  {
    IMemberDal _memberDal;
    public MemberManager(IMemberDal memberDal)
    {
      _memberDal = memberDal;
    }

    public IResult Add(Member member)
    {
      throw new NotImplementedException();
    }
  }
}
