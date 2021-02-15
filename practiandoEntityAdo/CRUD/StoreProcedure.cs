using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiandoEntityAdo.Models;

namespace practiandoEntityAdo.CRUD
{
    class StoreProcedure
    {
        /*
         ALTER procedure [dbo].[SPPrueba]
        @id int
        as 
        begin
        delete from PrimerCrudTable where idUsuario=@id
        end
        */
        public static void ExecSP(int id)
        {
            using (PrimerCrudEntities db = new PrimerCrudEntities())
            {
                //ejecuta un SP que elimina un usuario según un id
                db.SPPrueba(id);
            }
        }
       

    }
}
