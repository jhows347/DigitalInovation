using System;
using System.Collections.Generic;
using Filmes.Base.RepositoriosBase;

namespace Filmes.Repositorio
{
    public class FilmesRepositorio<Filmes> : RepositorioBase<Filmes>
    {
        List<Filmes> ListaFilmes;
        public FilmesRepositorio()
        {
          ListaFilmes = new List<Filmes>();   
        }
        public override void adicionar(Filmes obj)
        {
                ListaFilmes.Add(obj);
        }

        public override void atualizar(int id, Filmes obj)
        {
            ListaFilmes[id] = obj;
        }

        public override List<Filmes> listar()
        {
            return ListaFilmes;
        }

        public Filmes GetById(int id){
            return ListaFilmes[id];
        }
        public override void remover(int id)
        {

          Filmes filme = GetById(id);
          atualizar(id, filme);
                        
        }
    }
}