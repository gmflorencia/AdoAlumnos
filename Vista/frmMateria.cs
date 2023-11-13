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
    public partial class frmMateria : Form
    {
        L_Materia l_Materia = new L_Materia();
        public frmMateria()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmMateria_Load_1(object sender, EventArgs e)
        {
            dgvMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateria.MultiSelect = false;
            dgvMateria.AllowUserToAddRows = false;
            dgvMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMateria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMateria.BorderStyle = BorderStyle.None;
            dgvMateria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMateria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMateria.ColumnHeadersHeight = 30;
            dgvMateria.GridColor = Color.SteelBlue;
            dgvMateria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMateria.BackgroundColor = DefaultBackColor;
            dgvMateria.RowHeadersVisible = false;
            dgvMateria.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvMateria.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvMateria.EnableHeadersVisualStyles = false;

            BuscarTodas();
        }
        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            modificarMateria();
            BuscarTodas();
        }
        private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int valor = Convert.ToInt32(dgvMateria.CurrentRow.Index);
            l_Materia.IdMateria = (int)dgvMateria[0, valor].Value;
            txtNombreMateria.Text = dgvMateria[1, valor].Value.ToString();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            l_Materia.Nombre = txtNombreMateria.Text;
            l_Materia.Guardar();
            Limpiar.LimpiarControles(this);
            BuscarTodas();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarMateria();
            BuscarTodas();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos

        private void BuscarTodas(string datos = null)
        {
            dgvMateria.DataSource = null;
            dgvMateria.DataSource = l_Materia.LN_BuscarTodos(datos);
        }
        private void modificarMateria()
        {
            l_Materia.Nombre = txtNombreMateria.Text;
            l_Materia.Modificar();
        }
        private void eliminarMateria()
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de Eliminar Materia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                l_Materia.Eliminar();
            }            
        }
        #endregion
    }
}
