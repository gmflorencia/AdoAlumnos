using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmLogin : Form
    {
        L_Preceptor l_Preceptor = new L_Preceptor();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string clave = txtClave.Text;

            // Verificar si se ingresaron ambos campos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, ingrese el correo electrónico y la clave.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin continuar con la validación
            }

            // Realizar la operación de inicio de sesión y abrir el formulario principal
            traerPreceptor(email, clave);


        }
        private void traerPreceptor(string mail = "", string clave = "")
        {
            guardarPreceptor();
            bool existePreceptor = l_Preceptor.LN_BuscarPreceptor(mail,clave);
            if (existePreceptor)
            {
                //this.Close();
                this.Visible = false;
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
                MessageBox.Show("Correo electrónico y/o clave incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void guardarPreceptor()
        {
            l_Preceptor.Email = txtEmail.Text;
            l_Preceptor.Clave = txtClave.Text;
        }
    }
}
