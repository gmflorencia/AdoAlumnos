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
    public partial class frmAlumnos : Form
    {
        L_Alumnos l_Alumnos = new L_Alumnos();
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

        private void buscarTodos(string datos = null)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = l_Alumnos.LN_BuscarTodos(datos);
        }


        #endregion
    }
}
