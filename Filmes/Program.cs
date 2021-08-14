using System;
using System.Collections.Generic;
using Filmes.Enum;
using Filmes.Repositorio;

namespace Filmes
{
    class Program
    {
    private static FilmesRepositorio<Filmes.Classes.Filmes> _filmesRepositorio = new FilmesRepositorio<Classes.Filmes>();        
      static void Main(string[] args)
        {
            
            
            
            
            Console.WriteLine("....Adicionando....");
            _filmesRepositorio.adicionar(new Classes.Filmes{
                 Id =1,
                 NomeFilme ="Sexta 13",
                 Genero = EnumGenero.Acao,
                 Excluido = false 
            });
            _filmesRepositorio.adicionar(new Classes.Filmes{
                 Id =2,
                 NomeFilme ="Noiva do Chucky",
                 Genero = EnumGenero.Terror,
                 Excluido = false 
            });
                var Filmes = _filmesRepositorio.listar();
                ListaFilmes(Filmes);
            
            Console.WriteLine("....Atualizando....");
            _filmesRepositorio.atualizar(0,new Classes.Filmes{
                 Id=1,
                 NomeFilme ="Pequenino",
                 Genero = EnumGenero.Comedia,
                 Excluido = false 
            });
            ListaFilmes(Filmes);
            
            Console.WriteLine("....Removendo....");
            var filme = _filmesRepositorio.GetById(0);
            filme.Excluido = true;
            _filmesRepositorio.atualizar(0, filme);
            ListaFilmes(Filmes);


        }
        public static void ListaFilmes(List<Classes.Filmes> Filmes)
        {
                foreach(var item in Filmes)
                {
                      Console.WriteLine("\nId: {0} , Nome: {1}, Genero: {2}, Excluido: {3}\n",item.Id,item.NomeFilme,item.Genero,item.Excluido ? "Sim": "Não")  ;
                }
        }
    }
}
