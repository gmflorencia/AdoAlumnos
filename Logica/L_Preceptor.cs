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
    public class L_Preceptor
    {
        D_Preceptor d_Preceptor = new D_Preceptor();

        #region ATRIBUTOS
        private int idPreceptor;
        private string nombre;
        private string apellido;
        private string email;
        private string clave;
        #endregion

        #region PROPERTIES
        public int IdPreceptor { get => idPreceptor; set { idPreceptor = value; } }
        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
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
                if (String.IsNullOrEmpty(apellido.ToString()))
                {
                    throw new Exception("El apellido no puede ser nulo o vacío");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                if (String.IsNullOrEmpty(email))
                {
                    throw new Exception("El email no puede ser nulo o vacío");
                }
            }
        }
        public string Clave
        {
            get => clave;
            set
            {
                clave = value;
                if (String.IsNullOrEmpty(clave))
                {
                    throw new Exception("La clave no puede ser nula o vacía");
                }
            }
        }
        #endregion

        #region METODOS
        public bool LN_BuscarPreceptor(string mail = "", string clave = "")
        {
            pasarDatos();
            return d_Preceptor.Buscar();
        }
        private void pasarDatos()
        {
            d_Preceptor.IdPreceptor = Convert.ToInt32(idPreceptor);
            d_Preceptor.Nombre = nombre;
            d_Preceptor.Email = email;
            d_Preceptor.Clave = clave;
        }
        #endregion
    }
}
