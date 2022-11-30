using KpsServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using TAO.MR.Entities.Concrete;

namespace TAO.MR.Business.ServiceAdapters
{
  public class KpsServiceAdapter : IKpsService
  {
    public bool ValidateUser(Member member)
    {
      KPSPublicSoapClient client = new KPSPublicSoapClient();
      return client.TCKimlikNoDogrula(Convert.ToInt64(member.NationalIdentity), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year);

       
    }
  }
}
