using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Servicios
{
    public static class Limpiar
    {
        public static void LimpiarControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is GroupBox | item is Panel) LimpiarControles(item);
                if (item is TextBox txt) txt.Text = null;
                if (item is ComboBox cmb) cmb.Text = null;
            }
        }
    }
}
