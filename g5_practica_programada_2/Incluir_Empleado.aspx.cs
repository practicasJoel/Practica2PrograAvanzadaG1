using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos.Clases;
using CapaDatos.Modelo;
using CapaLogica.Clases;

namespace g5_practica_programada_2.Empleado
{
    public partial class Incluir_Empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        MetodosLogica logicos = new MetodosLogica();
        EntidadEmpleado entemp = new EntidadEmpleado();

        protected void btn_Incluir_Click(object sender, EventArgs e)
        {
            TxtSal_Bruto.Text = Convert.ToString(Convert.ToUInt32(TxtSal_Hora.Text) * Convert.ToUInt32(TxtHoras.Text));
            entemp.codigo_empleado = Convert.ToInt32(TxtCodigo.Text);
            entemp.Nombre = TxtNombre.Text;
            entemp.Horas_laboradas = Convert.ToInt32(TxtHoras.Text);
            entemp.Salario_Hora = Convert.ToInt32(TxtSal_Hora.Text);
            entemp.Salario_Bruto = Convert.ToInt32(TxtSal_Bruto.Text);
            logicos.Incluir(entemp);
        }
    }
}