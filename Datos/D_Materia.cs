using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Materia : Conexion
    {
        #region ATRIBUTOS
        private int idMateria;
        private string nombre;
        OleDbParameter[] lista = null;
        #endregion

        #region PROPERTIES
        public int IdMateria { get => idMateria; set { idMateria = value; } }
        public string Nombre { get => nombre; set { nombre = value; } }
        #endregion

        #region METODOS
        public DataTable Buscar(string datos)
        {
            string sSQL;
            if (string.IsNullOrEmpty(datos))
            {
                sSQL = "Select * from Materia";
            }
            else
            {
                sSQL = "Select * from Materia where Nombre like ? ";

                OleDbParameter param1 = new OleDbParameter("Nombre", "%" + datos.Trim() + "%");
                List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
                lista = listaParametros.ToArray();
            }
            return Ejecutar(sSQL, lista, true);
        }
        public DataTable BuscarPorCampo(string campo, string dato)
        {
            string sSQL;

            sSQL = "Select * from Materia where " + campo + " = ? ";

            OleDbParameter param1 = new OleDbParameter(campo, dato);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            return Ejecutar(sSQL, lista, true);
        }
        public void InsertarMateria()
        {
            //instruccion sql parametrizada
            string sSql = "INSERT INTO Materia (Nombre) values (?)";
            OleDbParameter param1 = new OleDbParameter("Nombre", nombre);
            List<OleDbParameter> ListaParametros = new List<OleDbParameter>() { param1 };
            lista = ListaParametros.ToArray(); //convierto la lista en un array

            Ejecutar(sSql, lista); // llamo al metodo ejecutar con la consulta sql y los parametros como argumentos
        } 
        public void ModificarMateria()
        {
            string sSql = "UPDATE Materia set Nombre= ? Where IdMateria= ?";
            OleDbParameter param1 = new OleDbParameter("Nombre", nombre);
            OleDbParameter param2 = new OleDbParameter("IdMateria", idMateria);
            List<OleDbParameter> ListaParametros = new List<OleDbParameter>() { param1, param2 };
            lista = ListaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        public void EliminarMateriaAsignacion()
        {
            string sSql = "DELETE FROM AlumnoMateria WHERE IdMateria = ?";
            OleDbParameter param1 = new OleDbParameter("IdMateria", idMateria);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        public void EliminarMateria()
        {
            string sSql = "DELETE FROM Materia WHERE IdMateria = ?";
            OleDbParameter param1 = new OleDbParameter("IdMateria", idMateria);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }
        #endregion
    }
}
