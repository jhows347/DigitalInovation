using System.Collections.Generic;
using Filmes.Interface;

namespace Filmes.Base.RepositoriosBase
{
    public abstract class RepositorioBase<T> : Interface.InterfaceBase<T>
    {
        public abstract void adicionar(T obj);
       

        public abstract void atualizar(int id, T obj);
        

        public abstract List<T> listar();
        

        public abstract void remover(int id);
        
    }
}