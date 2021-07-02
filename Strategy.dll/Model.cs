using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Strategy.dll
{
   //relationship-one to many
    public class Office              //Entity -Office
    {
        [Key]
        public int empid { get; set; }

        [StringLength(50)]
        public string empname { get; set; }          //applied to only string property , if string value set to more than 50 characters will throw validation error


        //using foreign key
        //The ForeignKey attribute is used to configure a foreign key in the relationship between two entities in EF 6 and EF Core
        //EF makes a property as foreign key property when its name matches with the primary key property of a related entity.

        public int did { get; set; }

        [ForeignKey("did")]                                       //[ForeignKey] on the navigation property
        public Department department { get; set; }              // navigation property

    }
    //foreign key did will be created in Office table preventing generation of depid in database

    //a property did in Office  entity matches with primary key of Department entity so did will automatically become foregin key property
   
    public class Department              //Entity -Department
    {
        [Key]
        public int depid { get; set; }

      [ConcurrencyCheck]
        public string dname { get; set; }         //concurrency check is applied to update , go to program.cs

        [MaxLength(20)]
        public string dtype { get; set; }       //max length specifies dname cannot be of more than 20 characters     
        public ICollection<Office> offices { get; set; }            //collection navigation property
        // ICollection declares an object for an in-memory collection. 
        // ICollection is a write operation
        //ICollection uses the following to modify the collection: Add(), Remove(),Clear(),IsReadOnly
    

    }
}
