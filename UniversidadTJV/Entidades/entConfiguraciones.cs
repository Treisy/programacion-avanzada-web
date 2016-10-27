using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entConfiguraciones
    {
        //Atributos
        private int _idConfiguracion;
        private string _nombreInstitucion;
        private string _logo;
        private string _cuatrimestre;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //COnstructor
        public entConfiguraciones()
        {
            IdConfiguracion = 0;
            NombreInstitucion = string.Empty;
            Logo = string.Empty;
            Cuatrimestre = string.Empty;
            UsuarioIngresa = 0;
            UsuarioModifica = 0;
    }

        //Encapsulamientos
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

        public string Logo
        {
            get
            {
                return _logo;
            }

            set
            {
                _logo = value;
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

        public string NombreInstitucion
        {
            get
            {
                return _nombreInstitucion;
            }

            set
            {
                _nombreInstitucion = value;
            }
        }
    }
}
