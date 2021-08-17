using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePlaylist.Models;

namespace TestePlaylist.Repository
{
    public class ArtistasRepository : IRepository<Artistas>
    {
        private List<Artistas> _artistas;

        public ArtistasRepository()
        {
            _artistas = new List<Artistas>();
        }
        public void Atualizar(int id, Artistas entidade)
        {
            _artistas[id] = entidade;
        }

        public Artistas consultar(int id)
        {
            return _artistas[id];
        }

        public void Insere(Artistas entidade)
        {
            throw new NotImplementedException();
        }

        public List<Artistas> ListarTodos()
        {
            return new List<Artistas>
            {
                new Artistas {  Id = Guid.NewGuid(), Nome = "Racionais"},
                new Artistas { Id = Guid.NewGuid(), Nome="Slipknot" },
                new Artistas {  Id = Guid.NewGuid(), Nome = "Revelação"},
                new Artistas { Id = Guid.NewGuid(), Nome="Arlindo Cruz" }
            };
        }

        public int Proximo()
        {
            return _artistas.Count;
        }
    }
}