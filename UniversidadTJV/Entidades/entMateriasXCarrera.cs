using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entMateriasXCarrera
    {
        //Atributos
        private int _id;
        private float _costo;
        private int _idCarrera;
        private int _idMateria;
        private int _usuarioIngresa;
        private int _usuarioModifica;

        //Constructor
        public entMateriasXCarrera()
        {
            Id = 0;
            Costo = 0;
            IdCarrera = 0;
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

        public float Costo
        {
            get
            {
                return _costo;
            }

            set
            {
                _costo = value;
            }
        }

        public int IdCarrera
        {
            get
            {
                return _idCarrera;
            }

            set
            {
                _idCarrera = value;
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
