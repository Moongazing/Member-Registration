using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Business.Abstract;
using TAO.MR.Business.Concrete;
using TAO.MR.Business.ServiceAdapters;
using TAO.MR.DataAccess.Abstract;
using TAO.MR.DataAccess.Concrete.EntityFramework;

namespace TAO.MR.Business.DependencyResolvers.Autofac
{
  public class AutofacBusinessModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
      builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();

      builder.RegisterType<IKpsService>().As<KpsServiceAdapter>().SingleInstance();
    }
  }
}
