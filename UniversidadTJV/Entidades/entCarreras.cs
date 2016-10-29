using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entCarreras
    {
        //Atributos
        private int _idCarrera;
        private string _nombre;
        private string _descripcion;
        private int _usuarioIngresa;
        private int _usuarioModifica;
        private int _idProfesor;

        //Constructor
        public entCarreras()
        {
            IdCarrera = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
            IdProfesor = 0;
        }

        //Encpasulamientos
        public int IdCarrera
        {
            get
            {
                return _idCarrera;
            }

            set
            {
                _idCarrera = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public int UsuarioIngresa
        {
            get
            {
                return _usuarioIngresa;
            }

            set
            {
                _usuarioIngresa = value;
            }
        }

        public int UsuarioModifica
        {
            get
            {
                return _usuarioModifica;
            }

            set
            {
                _usuarioModifica = value;
            }
        }

        public int IdProfesor
        {
            get
            {
                return _idProfesor;
            }

            set
            {
                _idProfesor = value;
            }
        }
    }
}
