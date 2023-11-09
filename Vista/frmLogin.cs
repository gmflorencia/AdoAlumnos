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
            traerPreceptor(txtEmail.ToString(), txtClave.ToString());
        }
        private void traerPreceptor(string mail = "", string clave = "")
        {
            guardarPreceptor();
            bool existePreceptor = l_Preceptor.LN_BuscarPreceptor(mail,clave);
            frmAlumnos frmAlumnos = new frmAlumnos();
            frmAlumnos.ShowDialog();

        }
        private void guardarPreceptor()
        {
            l_Preceptor.Email = txtEmail.Text;
            l_Preceptor.Clave = txtClave.Text;
        }
    }
}
