using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class EntidadEmpleado
    {
        public int codigo_empleado { get; set; }
        public string Nombre { get; set; }
        public int Horas_laboradas { get; set; }
        public int Salario_Hora { get; set; }
        public int Salario_Bruto { get; set; }
    }
}
