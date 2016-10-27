using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entTiposXInstitucion
    {
        //Atributos
        private int _id;
        private string _descripcion;
        private int _idConfiguracion;
        private int _idTipo;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entTiposXInstitucion()
        {
            Id = 0;
            Descripcion = string.Empty;
            IdConfiguracion = 0;
            IdTipo = 0;
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

        public int IdConfiguracion
        {
            get
            {
                return _idConfiguracion;
            }

            set
            {
                _idConfiguracion = value;
            }
        }

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
