using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_Materia
    {
        D_Materia d_Materia = new D_Materia();
        #region ATRIBUTOS
        private int idMateria;
        private string nombre;
        #endregion

        #region PROPERTIES
        public int IdMateria { get => idMateria; set { idMateria = value; } }
        public string Nombre { get => nombre; set { nombre = value; } }
        #endregion

        #region METODOS
        public DataTable LN_BuscarPorNombre(string campo, string dato)
        {
            return d_Materia.BuscarPorCampo(campo, dato);
        }
        public DataTable LN_BuscarTodos(string datos = "")
        {
            return d_Materia.Buscar(datos);
        }
        public void Guardar()
        {
            pasarDatos();
            d_Materia.InsertarMateria();
        }
        private void pasarDatos()
        {
            d_Materia.IdMateria = Convert.ToInt32(idMateria);
            d_Materia.Nombre = nombre;            
        }
        public void Modificar()
        {
            pasarDatos();
            d_Materia.ModificarMateria();
        }
        public void Eliminar()
        {
            pasarDatos();
            d_Materia.EliminarMateriaAsignacion();
            d_Materia.EliminarMateria();
        }
        #endregion
    }
}
