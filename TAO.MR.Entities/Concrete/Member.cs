using System;
using System.Collections.Generic;
using System.Text;
using TAO_Core.Entities;

namespace TAO.MR.Entities.Concrete
{
  public class Member:IEntity
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NationalIdentity { get; set; }
    public string Email { get; set; }
  }
}
