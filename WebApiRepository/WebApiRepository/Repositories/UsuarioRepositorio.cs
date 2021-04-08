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
        private readonly WarDbContext context;

        public UsuarioRepositorio(WarDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Usuario>> listarTodos()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> obtenerPorId(long id)
        {
            return await context.Usuarios.FindAsync(id);
        }

        public void agregar(Usuario entity)
        {
            context.Usuarios.Add(entity);
        }
        public void actualizar(Usuario entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public async void eliminar(long id)
        {
            Usuario entity = await obtenerPorId(id);
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
