using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Alumno : Conexion // aplico herencia 
    {
        #region ATRIBUTOS
        private int idAlumno;
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private string email;
        OleDbParameter[] lista = null;
        #endregion

        #region PROPERTIES
        public int IdAlumno { get => idAlumno; set { idAlumno = value; } }
        public string Nombre { get => nombre; set { nombre = value; } }
        public string Apellido { get => apellido; set { apellido = value; } }
        public int Dni { get => dni; set { dni = value; } }
        public int Edad { get => edad; set { edad = value; } }
        public string Email { get => email; set { email = value; } }
        #endregion

        #region METODOS
        public DataTable Buscar(string datos)
        {
            string sSQL;
            if (string.IsNullOrEmpty(datos))
            {
                sSQL = "Select * from Alumno";
            }
            else
            {
                sSQL = "Select * from Alumnos where Nombre like ? ";

                OleDbParameter param1 = new OleDbParameter("Nombre", "%" + datos.Trim() + "%");
                List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
                lista = listaParametros.ToArray();
            }
            return Ejecutar(sSQL, lista, true);
        }
        public DataTable BuscarPorCampo(string campo, string dato)
        {
            string sSQL;
            
            sSQL = "Select * from Alumno where " + campo + " = ? ";

            OleDbParameter param1 = new OleDbParameter( campo,dato);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();
            
            return Ejecutar(sSQL, lista, true);
        }
        // Inserta un nuevo registro
        public void InsertarAlumno()
        {
            //instruccion sql parametrizada
            string sSql = "INSERT INTO Alumno (Nombre, Apellido, Dni, Edad, Email) values (?,?,?,?,?)";
            OleDbParameter param1 = new OleDbParameter("Nombre", Nombre );
            OleDbParameter param2 = new OleDbParameter("Apellido", Apellido);
            OleDbParameter param3 = new OleDbParameter("Dni", Dni);
            OleDbParameter param4 = new OleDbParameter("Edad", Edad);
            OleDbParameter param5 = new OleDbParameter("Email", Email);
            //creo una lista con los parametros
            List<OleDbParameter> ListaParametros = new List<OleDbParameter>() { param1 , param2 , param3 , param4, param5};
            lista = ListaParametros.ToArray(); //convierto la lista en un array

            Ejecutar (sSql, lista); // llamo al metodo ejecutar con la consulta sql y los parametros como argumentos
        }
        public void ModificarAlumno()
        {
            string sSql = "UPDATE Alumno set Nombre= ?, Apellido= ?, Dni =?, Edad = ?, Email =? WHERE IdAlumno = ?";
            OleDbParameter param1 = new OleDbParameter("Nombre", Nombre);
            OleDbParameter param2 = new OleDbParameter("Apellido", Apellido);
            OleDbParameter param3 = new OleDbParameter("Dni", Dni);
            OleDbParameter param4 = new OleDbParameter("Edad", Edad);
            OleDbParameter param5 = new OleDbParameter("Email", Email);
            OleDbParameter param6 = new OleDbParameter ("IdAlumno", IdAlumno);

            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2, param3, param4, param5, param6};
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        public void EliminarAlumnoAsignacion()
        {
            string sSql = "DELETE FROM AlumnoMateria WHERE IdAlumno = ?";
            OleDbParameter param1 = new OleDbParameter("IdAlumno", IdAlumno);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        public void EliminarAlumno()
        {
            string sSql = "DELETE FROM Alumno WHERE IdAlumno = ?";
            OleDbParameter param1 = new OleDbParameter("IdAlumno", IdAlumno);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }

        #endregion
    }
}
