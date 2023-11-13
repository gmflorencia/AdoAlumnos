using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_AlumnoMateria
    {
        D_AlumnoMateria d_AlumnoMateria = new D_AlumnoMateria();

        #region ATRIBUTOS
        private int idAlumno;
        private int idMateria;
        #endregion

        #region PROPERTIES
        public int IdAlumno { get => idAlumno; set { idAlumno = value; } }
        public int IdMateria { get => idMateria; set { idMateria = value; } }
        #endregion

        #region METODOS
        public DataTable LN_BuscarTodos()
        {
            pasarDatos();
            return d_AlumnoMateria.Buscar();
        }
        public DataTable LN_BuscarMateria(string dato = "")
        {
            pasarDatos();
            return d_AlumnoMateria.BuscarMateria(dato);
        }
        private void pasarDatos()
        {
            d_AlumnoMateria.IdAlumno = idAlumno;
            d_AlumnoMateria.IdMateria = IdMateria; 
        }
        public void Guardar()
        {
            pasarDatos();
            d_AlumnoMateria.InsertarAlumnoMateria();
        }
        public void Quitar()
        {
            pasarDatos();
            d_AlumnoMateria.EliminarAlumnoMateria();
        }
        #endregion

    }
}
