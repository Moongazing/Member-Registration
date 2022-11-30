using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Entities.Concrete;

namespace TAO.MR.Business.ServiceAdapters
{
  public interface IKpsService
  {
    bool ValidateUser(Member member);
  }
}
