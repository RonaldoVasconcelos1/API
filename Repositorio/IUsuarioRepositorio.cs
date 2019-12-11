using System.Collections;
using System.Collections.Generic;
using API_BASICA.Models;

namespace API_BASICA.Repositorio
{
    public interface IUsuarioRepositorio
    {
         void Add(Usuarios usuario);
         IEnumerable<Usuarios> GetAll();
         Usuarios Find(long id);
         void Remove(long id);
         void Update(Usuarios usuario);
    }
}