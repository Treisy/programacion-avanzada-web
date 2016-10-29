using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class negMaterias
    {
        dalMaterias _MateriasDatos = new dalMaterias();
        public DataTable ListarMaterias()
        {
            return _MateriasDatos.ListarMaterias();
        }

        public entMaterias ConsultarMateria(int idMateria)
        {
            return _MateriasDatos.ConsultarMaterias(idMateria);
        }

        public string EliminarMateria(int idMateria)
        {
            return _MateriasDatos.EliminarMateria(idMateria);
        }

        public string AgregarMateria(string nombre, string codigo, int usuario_ingresa, int usuario_modifica)
        {
            return _MateriasDatos.AgregarMateria(nombre, codigo, usuario_ingresa, usuario_modifica);
        }

        public string ModificarMateria(string nombre, string codigo, int usuario_modifica)
        {
            return _MateriasDatos.ModificarMateria(nombre, codigo, usuario_modifica);
        }

        public DataTable BuscarMateria(string valor)
        {
            return _MateriasDatos.BuscarMaterias(valor);
        }
    }
}
