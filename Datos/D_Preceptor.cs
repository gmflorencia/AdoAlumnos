using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Preceptor : Conexion
    {
        #region ATRIBUTOS
        private int idPreceptor;
        private string nombre;
        private int apellido;
        private string email;
        private string clave;
        OleDbParameter[] lista = null;
        #endregion

        #region PROPERTIES
        public int IdPreceptor
        {
            get => idPreceptor;
            set { idPreceptor = value; }
        }
        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }
        public string Email
        {
            get => email;
            set { email = value; }
        }
        public string Clave
        {
            get => clave;
            set { clave = value; }
        }

        #endregion

        #region METODOS
        public bool Buscar()
        {
            string sSQL;
            DataTable dtDatos;

            sSQL = "Select * from Preceptor where email = ? and clave = ? ";

            OleDbParameter param1 = new OleDbParameter("email", email.ToString());
            OleDbParameter param2 = new OleDbParameter("clave", clave.ToString());
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2 };
            lista = listaParametros.ToArray();

            dtDatos = Ejecutar(sSQL, lista, true);
            if (dtDatos.Rows.Count == 0) return false; 
            return true;
        }
        #endregion
    }
}
