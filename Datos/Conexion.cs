using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Datos
{
    public abstract class Conexion
    {
        private readonly string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|AlumnosDB.accdb";
        public DataTable Ejecutar(string sSQL, OleDbParameter[] lista, bool consulta = false)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(cadena))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sSQL, conn);

                if (lista!=null) command.Parameters.AddRange(lista);
                
                if (consulta)
                {
                    dt.Load(command.ExecuteReader());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
                
                command.Parameters.Clear();
            }
            
            return dt;
        }
    }

}
