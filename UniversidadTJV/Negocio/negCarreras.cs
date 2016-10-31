using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class negCarreras
    {
        dalCarreras _CarrerasDatos = new dalCarreras();
        public DataTable ListarCarreras()
        {
            return _CarrerasDatos.ListarCarreras();
        }

        public entCarreras ConsultarCarrera(int idCarrera)
        {
            return _CarrerasDatos.ConsultarCarreras(idCarrera);
        }

        public string EliminarCarrera(int idCarrera)
        {
            return _CarrerasDatos.EliminarCarrera(idCarrera);
        }

        public string AgregarCarrera(string nombre, string descripcion, int id_profesor,  int usuario_ingresa, int usuario_modifica)
        {
            return _CarrerasDatos.AgregarCarrera(nombre, descripcion, id_profesor, usuario_ingresa, usuario_modifica);
        }

        public string ModificarCarrera(string nombre, string descripcion, int id_profesor, int usuario_modifica)
        {
            return _CarrerasDatos.ModificarCarrera(nombre, descripcion, id_profesor, usuario_modifica);
        }

        public DataTable BuscarCarrera(string valor)
        {
            return _CarrerasDatos.BuscarCarreras(valor);
        }

        public string AgregarMateriasXCarrera(float costo, int id_carrera, int id_materia, int usuario_ingresa, int usuario_modifica)
        {
            return _CarrerasDatos.AgregarMateriasXCarrera(costo, id_carrera, id_materia, usuario_ingresa, usuario_modifica);
        }

        public DataTable ListarMateriasXCarrera(int id_carrera)
        {
            return _CarrerasDatos.ListarMateriasXCarrera(id_carrera);
        }

        public string EliminarMateriasXCarrera(int id)
        {
            return _CarrerasDatos.EliminarMateriasXCarrera(id);
        }
    }
}
