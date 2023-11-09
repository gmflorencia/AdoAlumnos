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
    public class L_Alumnos
    {
        D_Alumnos d_Alumnos = new D_Alumnos();

        #region ATRIBUTOS
        private int idAlumno;
        private string nombre;
        private int dni;
        private string email;
        private string password;
        #endregion

        #region PROPERTIES
        public int IdAlumno { get => idAlumno; set { idAlumno = value; } }
        public string Nombre 
        { 
            get => nombre; 
            set { nombre = value;
                if (String.IsNullOrEmpty(nombre))
                {
                    throw new Exception("El Nombre no puede ser nulo o vacío");
                }
            } 
        }
        public int Dni 
        { 
            get => dni; 
            set { dni = value;
                if (String.IsNullOrEmpty(dni.ToString()))
                {
                    throw new Exception("El dni no puede ser nulo o vacío");
                }
            } 
        }
        public string Email 
        { 
            get => email; 
            set { email = value;
                if (String.IsNullOrEmpty(email))
                {
                    throw new Exception("El email no puede ser nulo o vacío");
                }
            } 
        }
        public string Password 
        { 
            get => password; 
            set { password = value;
                if (String.IsNullOrEmpty(password))
                {
                    throw new Exception("La clave no puede ser nula o vacía");
                }
            } 
        }
        #endregion

        #region METODOS
        public DataTable LN_BuscarTodos(string datos = "")
        {
            return d_Alumnos.Buscar(datos);
        }
        public void GuardarAlumno()
        {
            
        }
        #endregion
    }
}
