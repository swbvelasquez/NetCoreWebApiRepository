using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Models;

namespace WebApiRepository.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<IEnumerable<Usuario>> listarTodos();
        Task<Usuario> obtenerPorId(long id);
        void agregar(Usuario entity);
        void actualizar(Usuario entity);
        void eliminar(long id);
        Task<int> guardarCambios();
        void liberarRecursos();
    }
}
