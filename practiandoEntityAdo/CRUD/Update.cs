using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo.CRUD
{
    class Update
    {
        public static void UpdateUser(string nombre, string nuevoCorreo, DateTime nuevaFecha)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                PrimerCrudTable table = db.PrimerCrudTable.Where(user => user.nombre == nombre).First();
                table.correo = nuevoCorreo;
                table.fechaNacimiento = nuevaFecha;
                db.Entry(table).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
