using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProfesoresXLugar
    {
        //Atributos
        private int _id;
        private int _idProfesor;
        private int _idLugar;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entProfesoresXLugar()
        {
            Id = 0;
            IdProfesor = 0;
            IdLugar = 0;
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

        public int IdLugar
        {
            get
            {
                return _idLugar;
            }

            set
            {
                _idLugar = value;
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
