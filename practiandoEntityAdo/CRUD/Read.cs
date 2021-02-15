using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo.CRUD
{
    class Read
    {
        public static void ReadUser()
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                var table = db.PrimerCrudTable;

                foreach (var user in table)
                {
                    Console.WriteLine(user.nombre);
                }
            }
        }
    }
}
