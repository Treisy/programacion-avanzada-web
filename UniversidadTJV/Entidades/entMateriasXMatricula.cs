using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entMateriasXMatricula
    {
        //Atributos
        private int _id;
        private int _idMatricula;
        private int _idMateria;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entMateriasXMatricula()
        {
            Id = 0;
            IdMatricula = 0;
            IdMateria = 0;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
    }

        //Encapsulamientos
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

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

        public int IdMateria
        {
            get
            {
                return _idMateria;
            }

            set
            {
                _idMateria = value;
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
