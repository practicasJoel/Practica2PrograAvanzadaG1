using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;

namespace CapaDatos.Clases
{
     public class MetodosEmpleado
    {
        g5_practicaNo2Entities db = new g5_practicaNo2Entities();

        public bool Incluir(empleado emp)
        {
            db.empleadoes.Add(emp);
            db.SaveChanges();
            return true;
        }
    }
}
