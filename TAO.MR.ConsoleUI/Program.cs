using Autofac.Core;
using System;
using TAO.MR.Business.Abstract;
using TAO.MR.Business.Concrete;
using TAO.MR.Business.ServiceAdapters;
using TAO.MR.DataAccess.Concrete.EntityFramework;

namespace TAO.MR.ConsoleUI
{
  internal class Program
  {
    static void Main(string[] args)
    {
      MemberManager memberManager = new MemberManager(new EfMemberDal(),new KpsServiceAdapter(IKpsService));
    }
  }
}
