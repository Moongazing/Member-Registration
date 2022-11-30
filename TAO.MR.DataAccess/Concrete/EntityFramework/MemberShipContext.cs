using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using TAO.MR.Entities.Concrete;

namespace TAO.MR.DataAccess.Concrete.EntityFramework
{
  public class MemberShipContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database =MemberDb;Trusted_Connection=true");
    }
    public DbSet<Member> Members { get; set; }
  }
}
