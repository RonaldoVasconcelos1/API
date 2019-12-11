using System.Collections.Generic;
using API_BASICA.Models;
using API_BASICA.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace API_BASICA.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRep)
        {
            _usuarioRepositorio = usuarioRep;
        }

        [HttpGet]
        public IEnumerable<Usuarios> GetAll()
        {
            return _usuarioRepositorio.GetAll();
        }
        [HttpGet("{id}", Name="GetUsuarios")]
        public IActionResult getById(long id){
            var usuario = _usuarioRepositorio.Find(id);
            if(usuario == null){
                return NotFound();
            }
                return new ObjectResult(usuario);
        }
    }
}