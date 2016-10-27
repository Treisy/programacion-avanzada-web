using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entMatriculas
    {
        //Atributos
        private int _idMatricula;
        private string _cuatrimestre;
        private int _idAlumno;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entMatriculas()
        {
            IdMatricula = 0;
            Cuatrimestre = string.Empty;
            IdAlumno = 0;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
    }

        //Encapsulamientos
        public int IdMatricula
        {
            get
            {
                return _idMatricula;
            }

            set
            {
                _idMatricula = value;
            }
        }

        public string Cuatrimestre
        {
            get
            {
                return _cuatrimestre;
            }

            set
            {
                _cuatrimestre = value;
            }
        }

        public int IdAlumno
        {
            get
            {
                return _idAlumno;
            }

            set
            {
                _idAlumno = value;
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
