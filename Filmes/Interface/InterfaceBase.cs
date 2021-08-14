using System.Collections.Generic;

namespace Filmes.Interface
{
    public interface InterfaceBase<T>
    {
         void adicionar (T obj);
         List<T> listar();

         void remover(int id);

         void atualizar(int id, T obj);

    }
}