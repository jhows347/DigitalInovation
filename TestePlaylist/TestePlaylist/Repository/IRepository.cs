using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePlaylist.Repository
{
    public interface IRepository<T>
    {
        void Insere(T entidade);
        List<T> ListarTodos();

        void Atualizar(int id, T entidade);

        T consultar(int id);

        int Proximo();
    }
}
