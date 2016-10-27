using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entTipos
    {
        //Atributos
        private int _idTipo;
        private string _nombre;
        private string _tipo;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entTipos()
        {
            IdTipo = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
        }

        //Encapsulamientos
        public int IdTipo
        {
            get
            {
                return _idTipo;
            }

            set
            {
                _idTipo = value;
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

        public string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
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
