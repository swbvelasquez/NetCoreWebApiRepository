using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Interfaces;
using WebApiRepository.Models;

namespace WebApiRepository.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio repositorio;

        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> listarTodos()
        {
            IEnumerable<Usuario> listaResultado = await repositorio.listarTodos();
            return Ok(listaResultado); //codigo 200
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> obtenerPorId(int id)
        {
            Usuario usuario = await repositorio.obtenerPorId(id);

            if(usuario==null || usuario.IdUsuario == 0)
            {
                return NotFound();
            }

            return Ok(usuario);
        }
            
    }
}
