using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo.CRUD
{
    class Create
    {
        public static void AddUser(string nombre, string correo, DateTime fechaNacimiento)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                PrimerCrudTable table = new PrimerCrudTable();

                table.nombre = nombre;
                table.correo = correo;
                table.fechaNacimiento = fechaNacimiento;

                db.PrimerCrudTable.Add(table);
                db.SaveChanges();
            }
        }

    }
}
