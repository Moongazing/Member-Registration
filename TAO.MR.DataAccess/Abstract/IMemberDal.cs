using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Entities.Concrete;
using TAO_Core.DataAccess;

namespace TAO.MR.DataAccess.Abstract
{
  public interface IMemberDal : IEntityRepository<Member>
  {
  }
}
