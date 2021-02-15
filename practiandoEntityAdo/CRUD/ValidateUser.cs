using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;
using practiandoEntityAdo.Encriptar;

namespace practiandoEntityAdo.CRUD
{
    class ValidateUser
    {
        public static void Validate(string nombre, string correo)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                var objectUser = (from d in db.PrimerCrudTable
                                  where d.nombre == nombre && d.correo == Encriptador.EncriptarContra(correo)).FirstOrDefault();

                if (objectUser == null) { Console.WriteLine("No puede pasar"); }
                else { Console.WriteLine("Puede pasar"); }
                    
            }

           
        }
    }
}
