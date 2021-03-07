using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo.CRUD
{
    class Delete
    {
        public static void DeleteUSer(int id)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                PrimerCrudTable table = db.PrimerCrudTable.Where(s => s.idUsuario == id).FirstOrDefault();
                db.PrimerCrudTable.Remove(table);
                db.SaveChanges();
            }
        }


    }
}
