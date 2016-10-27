using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entLugares
    {
        //Atributos
        private int _idLugar;
        private string _nombre;
        private int _padreId;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entLugares()
        {
            IdLugar = 0;
            Nombre = string.Empty;
            PadreId = 0;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
        }

        //Encapsulamientos
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

        public int PadreId
        {
            get
            {
                return _padreId;
            }

            set
            {
                _padreId = value;
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
