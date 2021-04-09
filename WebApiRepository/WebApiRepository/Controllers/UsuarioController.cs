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
        public async Task<ActionResult<Usuario>> obtenerPorId(long id)
        {
            Usuario usuario = await repositorio.obtenerPorId(id);

            if(usuario==null || usuario.IdUsuario == 0)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> agregar(Usuario usuario)
        {
            int resultado = 0;
            Usuario usuarioExistente = await repositorio.obtenerPorId(usuario.IdUsuario);

            if (usuarioExistente != null)
            {
                return Conflict();
            }


            repositorio.agregar(usuario);
            resultado = await repositorio.guardarCambios();

            if (resultado <= 0)
            {
                return Conflict();
            }

            return CreatedAtAction(nameof(obtenerPorId), new { id  = usuario.IdUsuario}, usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> actualizar(long id, Usuario usuario)
        {
            int resultado = 0;
            Usuario usuarioExistente = await repositorio.obtenerPorId(usuario.IdUsuario);

            if(id != usuario.IdUsuario)
            {
                return BadRequest();
            }

            if (usuarioExistente == null)
            {
                return NotFound();
            }


            repositorio.actualizar(usuario);
            resultado = await repositorio.guardarCambios();

            if (resultado <= 0)
            {
                return Conflict();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> eliminar(long id)
        {
            int resultado = 0;
            Usuario usuarioExistente = await repositorio.obtenerPorId(id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }


            repositorio.eliminar(id);
            resultado = await repositorio.guardarCambios();

            if (resultado <= 0)
            {
                return Conflict();
            }

            return NoContent();
        }

        [HttpPatch("ActualizarDatosSecundarios/{id}")]
        public async Task<IActionResult> actualizarDatosSecundarios(long id, [FromQuery] String correo, [FromQuery] String nroCelular)
        {
            int resultado = 0;
            Usuario usuarioExistente = await repositorio.obtenerPorId(id);

            if (usuarioExistente == null)
            {
                return NotFound();
            }

            if (id != usuarioExistente.IdUsuario)
            {
                return BadRequest();
            }

            usuarioExistente.CorreoElectronico = correo;
            usuarioExistente.NroCelular = nroCelular;
            resultado = await repositorio.guardarCambios();

            if (resultado <= 0)
            {
                return Conflict();
            }

            return Ok(usuarioExistente);
        }
    }
}
