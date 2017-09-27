using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoWs2
{
    public partial class WFIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Configurar();
        }

        private void Configurar()
        {
            // Configuramos la forma
            LblTitulo.Text = "Convertir de Libras a Kilos";
            Label1.Text = "Libras";
            Button1.Text = "Convertir";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Consumimos el servicio
            ServicioConversion.ConvertWeightsSoapClient Conversion = new ServicioConversion.ConvertWeightsSoapClient();

            // Asignamos el valor a la etiqueta
            LblResultado.Text = "La conversion a Kilos es: " + Conversion.ConvertWeight(Double.Parse(TextBox1.Text), 
                ServicioConversion.WeightUnit.PoundsAvoir, 
                ServicioConversion.WeightUnit.Kilograms).ToString();
        }
    }
}