using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Datos
{
    public class D_AlumnoMateria : Conexion
    {
        #region ATRIBUTOS
        private int idAlumno;
        private int idMateria;
        OleDbParameter[] lista = null;
        #endregion

        #region PROPERTIES
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }   
        public int IdMateria { get => idMateria; set => idMateria = value; }
        #endregion

        #region METODOS
        public DataTable Buscar()
        {
            string sSQL;

            sSQL = "Select AlumnoMateria.IdAlumno, Alumno.Nombre AS Alumno_Nombre, AlumnoMateria.IdMateria, Materia.Nombre AS Materia_Nombre ";
            sSQL = sSQL + "FROM Alumno INNER JOIN (Materia INNER JOIN AlumnoMateria ON Materia.[IdMateria] = AlumnoMateria.[IdMateria]) ON Alumno.[IdAlumno] = AlumnoMateria.[IdAlumno] ";
            sSQL = sSQL + "WHERE (((AlumnoMateria.IdAlumno)= ? ));";

            OleDbParameter param1 = new OleDbParameter("IdAlumno", idAlumno);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };

            lista = listaParametros.ToArray();
 
            return Ejecutar(sSQL, lista, true);

        }
        public DataTable BuscarMateria(string dato = "")
        {
            string sSQL;

            sSQL = "Select Materia.IdMateria, Materia.Nombre ";
            sSQL = sSQL + "From Materia ";
            sSQL = sSQL + "Where NOT EXISTS (SELECT 1 FROM AlumnoMateria WHERE AlumnoMateria.IdMateria = Materia.IdMateria AND AlumnoMateria.IdAlumno = ?) ";
            sSQL = sSQL + "And Materia.Nombre Like ? ";
            OleDbParameter param1 = new OleDbParameter("IdAlumno", idAlumno);
            OleDbParameter param2 = new OleDbParameter("Nombre", "%" + dato.Trim() + "%");
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2 };

            lista = listaParametros.ToArray();

            return Ejecutar(sSQL, lista, true);
        }
        public void InsertarAlumnoMateria()
        {
            //instruccion sql parametrizada
            string sSql = "INSERT INTO AlumnoMateria (IdAlumno, IdMateria) values (?, ?)";
            OleDbParameter param1 = new OleDbParameter("IdAlumno", idAlumno);
            OleDbParameter param2 = new OleDbParameter("IdMateria", idMateria);

            List<OleDbParameter> ListaParametros = new List<OleDbParameter>() { param1, param2 };
            lista = ListaParametros.ToArray(); //convierto la lista en un array

            Ejecutar(sSql, lista); // llamo al metodo ejecutar con la consulta sql y los parametros como argumentos
        }
        public void EliminarAlumnoMateria()
        {
            string sSql = "DELETE FROM AlumnoMateria WHERE IdAlumno = ? and IdMateria = ?";
            OleDbParameter param1 = new OleDbParameter("IdAlumno", idAlumno);
            OleDbParameter param2 = new OleDbParameter("IdAlumno", idMateria);
            
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        #endregion
    }
}
