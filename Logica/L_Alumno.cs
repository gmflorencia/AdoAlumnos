using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_Alumno
    {
        D_Alumno d_Alumnos = new D_Alumno();

        #region ATRIBUTOS
        private int idAlumno;
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private string email;
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
        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                if (String.IsNullOrEmpty(apellido))
                {
                    throw new Exception("El Apellido no puede ser nulo o vacío");
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
        public int Edad
        {
            get => edad;
            set
            {
                edad = value;
                if (String.IsNullOrEmpty(edad.ToString()))
                {
                    throw new Exception("la edad no puede ser nulo o vacío");
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
        
        #endregion

        #region METODOS
        public DataTable LN_BuscarPorDNI(string campo, string dato)
        {
            return d_Alumnos.BuscarPorCampo(campo, dato);
        }
        public DataTable LN_BuscarTodos(string datos = "")
        {
            return d_Alumnos.Buscar(datos);
        }
        public void Guardar()
        {
            pasarDatos();
            d_Alumnos.InsertarAlumno();
        }
        private void pasarDatos()
        {
            d_Alumnos.IdAlumno = Convert.ToInt32(idAlumno);
            d_Alumnos.Nombre = nombre;
            d_Alumnos.Apellido = apellido;
            d_Alumnos.Dni = dni;
            d_Alumnos.Edad = edad;
            d_Alumnos.Email = email;
        }
        public void Modificar()
        {
            pasarDatos();
            d_Alumnos.ModificarAlumno();
        }
        public void Eliminar()
        {
            pasarDatos();
            d_Alumnos.EliminarAlumnoAsignacion();
            d_Alumnos.EliminarAlumno();
        }

        #endregion
    }
}
