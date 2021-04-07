using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Data;
using WebApiRepository.Interfaces;
using WebApiRepository.Models;

namespace WebApiRepository.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly UsuarioContext context;

        public UsuarioRepositorio(UsuarioContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Usuario>> listarEntidades()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> obtenerEntidadPorId(long id)
        {
            return await context.Usuarios.FindAsync(id);
        }

        public void agregarEntidad(Usuario entity)
        {
            context.Usuarios.Add(entity);
        }
        public void actualizarEntidad(Usuario entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public async void eliminarEntidad(long id)
        {
            Usuario entity = await obtenerEntidadPorId(id);
            context.Usuarios.Remove(entity);
        }

        public async Task<int> guardarCambios()
        {
            return await context.SaveChangesAsync();
        }

        public async void liberarRecursos()
        {
            await context.DisposeAsync();
        }
    }
}
