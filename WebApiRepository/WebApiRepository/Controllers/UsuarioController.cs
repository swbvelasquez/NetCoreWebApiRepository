using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Interfaces;

namespace WebApiRepository.Controllers
{
    [Route("api/{controller}")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio repositorio;

        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
