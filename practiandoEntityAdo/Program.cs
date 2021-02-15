using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //procedure
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                db.SPPrueba(6);
                db.SaveChanges();
            }
        }
    }
}
