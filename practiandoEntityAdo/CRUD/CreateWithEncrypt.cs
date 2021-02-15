using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;
using practiandoEntityAdo.Encriptar;

namespace practiandoEntityAdo.CRUD
{
    class CreateWithEncrypt
    {
        public static void CreateUserEncripted(string nombre,string correo, DateTime dateTime)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                PrimerCrudTable table = new PrimerCrudTable();
                table.nombre = nombre;
                //Como la tabla no tiene columna de contraseña, aquí voy a encriptar el correo
                table.correo = Encriptador.EncriptarContra(correo);
                table.fechaNacimiento = dateTime;
            }
        }

    }
}
