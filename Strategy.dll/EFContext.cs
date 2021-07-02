using System.Data.Entity;
namespace Strategy.dll
{
  public  class EFContext:DbContext
    {
        //create constructor
        public EFContext():base("office-department")      //name of database
        {
            
         
        }

        //create dbset
        public DbSet<Office> offices { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
