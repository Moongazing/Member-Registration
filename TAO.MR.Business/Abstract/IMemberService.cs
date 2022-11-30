using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Entities.Concrete;
using TAO_Core.Utilities.Results;

namespace TAO.MR.Business.Abstract
{
  public interface IMemberService
  {
    IResult Add(Member member);
  }
}
