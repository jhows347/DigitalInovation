using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePlaylist.Models;

namespace TestePlaylist.Repository
{
    public class GenerosRepository : IRepository<GenerosMusicais>
    {
        private List<GenerosMusicais> _generosMusicais;
        public GenerosRepository()
        {
            _generosMusicais = new List<GenerosMusicais>();
        }
        public void Atualizar(int id, GenerosMusicais entidade)
        {
            _generosMusicais[id] = entidade;
        }
        public GenerosMusicais consultar(int id)
        {
            return _generosMusicais[id];
        }
        public void Insere(GenerosMusicais entidade)
        {
            throw new NotImplementedException();
        }
        public List<GenerosMusicais> ListarTodos()
        {
            return new List<GenerosMusicais>
            {
                new GenerosMusicais {  Id = Guid.NewGuid(), Genero = "Rap Nacional"},
                new GenerosMusicais { Id = Guid.NewGuid(),  Genero = "Rock Internacional" },
                new GenerosMusicais { Id = Guid.NewGuid(),  Genero = "Samba" },
                new GenerosMusicais { Id = Guid.NewGuid(),  Genero = "Pagode" }
            };
        }
        public int Proximo()
        {
            return _generosMusicais.Count;
        }
    }
}