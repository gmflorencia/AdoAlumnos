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
using Vista.Servicios;


namespace Vista
{
    public partial class frmAlumnos : Form
    {
        L_Alumno l_Alumnos = new L_Alumno();
        public frmAlumnos()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAlumnos.BorderStyle = BorderStyle.None;
            dgvAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlumnos.ColumnHeadersHeight = 30;
            dgvAlumnos.GridColor = Color.SteelBlue;
            dgvAlumnos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlumnos.BackgroundColor = DefaultBackColor;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvAlumnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvAlumnos.EnableHeadersVisualStyles = false;

            buscarTodos();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardarAlumno();
            Limpiar.LimpiarControles(this);
            buscarTodos();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            modificarAlumno();
            buscarTodos();
        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = Convert.ToInt32(dgvAlumnos.CurrentRow.Index);
            l_Alumnos.IdAlumno = (int)dgvAlumnos[0, valor].Value;
            txtNombre.Text = dgvAlumnos[1, valor].Value.ToString();
            txtApellido.Text = dgvAlumnos[2, valor].Value.ToString();
            txtDni.Text = dgvAlumnos[3, valor].Value.ToString();
            txtEdad.Text = dgvAlumnos[4, valor].Value.ToString();
            txtEmail.Text = dgvAlumnos[5, valor].Value.ToString();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
            buscarTodos();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero.ValidarNro(e);
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero.ValidarNro(e);
        }
        #endregion

        #region Metodos
        private void buscarTodos(string datos = null)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = l_Alumnos.LN_BuscarTodos(datos);
        }
        private void guardarAlumno()
        {
            l_Alumnos.Nombre = txtNombre.Text;
            l_Alumnos.Apellido = txtApellido.Text;
            l_Alumnos.Dni = int.Parse(txtDni.Text);
            l_Alumnos.Edad = int.Parse(txtEdad.Text);
            l_Alumnos.Email = txtEmail.Text;
            l_Alumnos.Guardar();
        }
        private void modificarAlumno()
        {
            l_Alumnos.Nombre = txtNombre.Text;
            l_Alumnos.Apellido = txtApellido.Text;
            l_Alumnos.Dni = int.Parse(txtDni.Text);
            l_Alumnos.Edad = int.Parse(txtEdad.Text);
            l_Alumnos.Email = txtEmail.Text;
            l_Alumnos.Modificar();

        }
        private void eliminarAlumno()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de Eliminar Alumno?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                l_Alumnos.Eliminar();
            }
        }
        #endregion
    }

}
