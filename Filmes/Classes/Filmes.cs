using Filmes.Base.ClassesBase;
using Filmes.Enum;

namespace Filmes.Classes
{
    public class Filmes : EntidadeBase
    {
        public string NomeFilme { get; set; }

        public EnumGenero Genero { get; set; }

        public bool Excluido { get; set; }
    }
}