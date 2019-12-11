using System.Collections;
using System.Collections.Generic;
using System.Linq;
using API_BASICA.Models;

namespace API_BASICA.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly UsuarioDbContext _contexto;

        public UsuarioRepositorio(UsuarioDbContext ctx)
        {
            _contexto = ctx ;
        }
        public void Add(Usuarios usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

        public IEnumerable<Usuarios> GetAll()
        {
            return _contexto.Usuarios.ToList();
        }
        public Usuarios Find(long id)
        {
           return _contexto.Usuarios.FirstOrDefault(u => u.UsuarioId ==id);

        }

        public void Remove(long id)
        {
            var entidade = _contexto.Usuarios.First(u => u.UsuarioId == id);
            _contexto.Usuarios.Remove(entidade);
            _contexto.SaveChanges();

        }

        public void Update(Usuarios usuario)
        {
            _contexto.Usuarios.Update(usuario);
            _contexto.SaveChanges();
        }
    }
}