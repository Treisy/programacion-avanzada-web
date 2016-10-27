using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProfesores
    {
        //Atributos
        private int _idProfesor;
        private string _cedula;
        private string _nombre;
        private string _primerApellido;
        private string _segundoApellido;
        private DateTime _fechaNacimiento;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entProfesores()
        {
            IdProfesor = 0;
            Cedula = string.Empty;
            Nombre = string.Empty;
            PrimerApellido = string.Empty;
            SegundoApellido = string.Empty;
            FechaNacimiento = DateTime.Now;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
        }

        //Encapsulamientos
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

        public string PrimerApellido
        {
            get
            {
                return _primerApellido;
            }

            set
            {
                _primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return _segundoApellido;
            }

            set
            {
                _segundoApellido = value;
            }
        }

        public string Cedula
        {
            get
            {
                return _cedula;
            }

            set
            {
                _cedula = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }

            set
            {
                _fechaNacimiento = value;
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
    }

}
