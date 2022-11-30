using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.DataAccess.Abstract;
using TAO.MR.Entities.Concrete;
using TAO_Core.DataAccess.EntityFramework;

namespace TAO.MR.DataAccess.Concrete.EntityFramework
{
  public class EfMemberDal:EfEntityRepositoryBase<Member,MemberShipContext>,IMemberDal
  {
  }
}
