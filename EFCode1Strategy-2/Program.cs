using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.dll;
namespace EFCode1Strategy_2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new EFContext())
            {
                var dept = new Department()
                {
                    dname = "physics"
                };
                ctx.departments.Add(dept);
                ctx.SaveChanges();

                //now for [ConcurrencyCheck]  update it
                dept.dname = "chemistry";           //department object.property name
                ctx.SaveChanges();
                //display data
                var io = ctx.departments.ToList();

                foreach (var i in io)
                {
                    Console.WriteLine(i.dname, i.dtype);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
