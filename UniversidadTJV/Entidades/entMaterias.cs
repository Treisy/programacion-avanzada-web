using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entMaterias
    {
        //Atributos
        private int _idMateria;
        private string _nombre;
        private string _codigo;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entMaterias()
        {
            IdMateria = 0;
            Nombre = string.Empty;
            Codigo = string.Empty;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
        }

        //Encapsulamientos
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

        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
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
