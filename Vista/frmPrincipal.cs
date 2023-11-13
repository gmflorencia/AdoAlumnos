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
    public partial class frmPrincipal : Form
    {
        L_Alumno l_Alumnos = new L_Alumno();
        L_Materia l_Materia = new L_Materia();
        L_AlumnoMateria l_AlumnoMateria = new L_AlumnoMateria();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void altaBajaModificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.ShowDialog();
        }
        #region EVENTOS
        private void frmPrincipal_Load(object sender, EventArgs e)
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

            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.MultiSelect = false;
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMaterias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaterias.BorderStyle = BorderStyle.None;
            dgvMaterias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaterias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaterias.ColumnHeadersHeight = 30;
            dgvMaterias.GridColor = Color.SteelBlue;
            dgvMaterias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaterias.BackgroundColor = DefaultBackColor;
            dgvMaterias.RowHeadersVisible = false;
            dgvMaterias.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvMaterias.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvMaterias.EnableHeadersVisualStyles = false;

            dgvAsignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignaciones.MultiSelect = false;
            dgvAsignaciones.AllowUserToAddRows = false;
            dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAsignaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAsignaciones.BorderStyle = BorderStyle.None;
            dgvAsignaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAsignaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAsignaciones.ColumnHeadersHeight = 30;
            dgvAsignaciones.GridColor = Color.SteelBlue;
            dgvAsignaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAsignaciones.BackgroundColor = DefaultBackColor;
            dgvAsignaciones.RowHeadersVisible = false;
            dgvAsignaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvAsignaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvAsignaciones.EnableHeadersVisualStyles = false;

            traerTodosAlumnos();
            verificarBotones();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "") 
            {
                traerTodosAlumnos();            }
            else
            {
                traerAlumno("DNI", txtDNI.Text);
                pasarDatosAsignaciones();
                traerAsignaciones();
                traerMateriasSinAsignar(txtMateria.Text);
            }
            verificarBotones();
        }
        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            traerMateriasSinAsignar(txtMateria.Text);

        }
        private void altaBajaModificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMateria materia = new frmMateria();
            materia.ShowDialog();
        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pasarDatosAlumnos();
            pasarDatosAsignaciones();
            traerMateriasSinAsignar(txtMateria.Text);
            traerAsignaciones();
            verificarBotones();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarAlumnoMateria();
            traerAsignaciones();
            traerMateriasSinAsignar();
            verificarBotones();
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            quitarAlumnoMateria();
            traerAsignaciones();
            traerMateriasSinAsignar();
            verificarBotones();
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero.ValidarNro(e);
        }
        #endregion

        #region METODOS
        private void traerTodosAlumnos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = l_Alumnos.LN_BuscarTodos();
        }
        private void traerAlumno(string campo, string dato = null)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = l_Alumnos.LN_BuscarPorDNI(campo, dato);
        }
        private void traerMateriasSinAsignar(string dato = "")
        {
            dgvMaterias.DataSource = null;
            dgvMaterias.DataSource = l_AlumnoMateria.LN_BuscarMateria(dato);
        }
        private void traerAsignaciones()
        {
            dgvAsignaciones.DataSource = null;
            dgvAsignaciones.DataSource = l_AlumnoMateria.LN_BuscarTodos();
        }
        private void pasarDatosAlumnos()
        {
            int valor = Convert.ToInt32(dgvAlumnos.CurrentRow.Index);
            l_Alumnos.IdAlumno = (int)dgvAlumnos[0, valor].Value;
            l_Alumnos.Nombre = dgvAlumnos[1, valor].Value.ToString();
            l_Alumnos.Apellido = dgvAlumnos[2, valor].Value.ToString();
            l_Alumnos.Dni = (int)dgvAlumnos[3, valor].Value;
            l_Alumnos.Edad = (int)dgvAlumnos[4, valor].Value;
            l_Alumnos.Email = dgvAlumnos[5, valor].Value.ToString();
        }

        private void pasarDatosAsignaciones()
        {
            int valor = Convert.ToInt32(dgvAlumnos.CurrentRow.Index);
            l_AlumnoMateria.IdAlumno = (int)dgvAlumnos[0, valor].Value;
        }
        private void guardarAlumnoMateria()
        {
            pasarSeleccionadosAgregar();
            l_AlumnoMateria.Guardar();
        }
        private void quitarAlumnoMateria()
        {
            pasarSeleccionadosQuitar();
            l_AlumnoMateria.Quitar();
        }
        private void pasarSeleccionadosAgregar()
        {
            DataGridViewRow filaAlumno = dgvAlumnos.SelectedRows[0];
            DataGridViewRow filaMateria = dgvMaterias.SelectedRows[0];
            l_AlumnoMateria.IdAlumno = (int)filaAlumno.Cells["IdAlumno"].Value;
            l_AlumnoMateria.IdMateria = (int)filaMateria.Cells["IdMateria"].Value;
        }
        private void pasarSeleccionadosQuitar()
        {
            DataGridViewRow filaSeleccionada = dgvAsignaciones.SelectedRows[0];
            l_AlumnoMateria.IdAlumno = (int)filaSeleccionada.Cells["IdAlumno"].Value;
            l_AlumnoMateria.IdMateria = (int)filaSeleccionada.Cells["IdMateria"].Value;
        }
        private void verificarBotones()
        {
            btnAgregar.Enabled = dgvMaterias.RowCount >= 1 ? true : false;
            btnQuitar.Enabled = dgvAsignaciones.RowCount >= 1 ? true : false;
        }
        private void salir()
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
    }
}
