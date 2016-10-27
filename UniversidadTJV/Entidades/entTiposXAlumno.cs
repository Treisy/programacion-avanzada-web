using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entTiposXAlumno
    {
        private int _id;
        private string _descripcion;
        private int _idAlumno;
        private int _idTipo;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entTiposXAlumno()
        {
            Id = 0;
            Descripcion = string.Empty;
            IdAlumno = 0;
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
