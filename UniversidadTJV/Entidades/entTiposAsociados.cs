using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class entTiposAsociados
    {
        private int id;
        private string descripcion;
        private char estado;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public entTiposAsociados(int id, string descripcion)
        {
            this.descripcion = descripcion;
            this.id = id;
        }
            
    }
}
