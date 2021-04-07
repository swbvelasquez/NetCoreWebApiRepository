using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Models;

namespace WebApiRepository.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<IEnumerable<Usuario>> listarEntidades();
        Task<Usuario> obtenerEntidadPorId(long id);
        void agregarEntidad(Usuario entity);
        void actualizarEntidad(Usuario entity);
        void eliminarEntidad(long id);
        Task<int> guardarCambios();
        void liberarRecursos();
    }
}
