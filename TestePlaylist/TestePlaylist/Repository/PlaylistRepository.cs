using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using TestePlaylist.Models;

namespace TestePlaylist.Repository
{
    public class PlaylistRepository : IRepository<Playlists>
    {
        #region Variaveis Locais

        List<Playlists> _playlist = new List<Playlists>();
        List<Playlists> _playlistTemp = new List<Playlists>();

        private MemoryCache _memoryCache;
        private string keyOptions = "keyPlaylist";
        private MemoryCacheEntryOptions _memoryOptions;

        #endregion

        #region Construtor

        public PlaylistRepository()
        {
            _memoryCache = new MemoryCache(new MemoryCacheOptions());
            _memoryOptions = new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromMinutes(30) };

        }
        #endregion

        #region Metodos Memory

       
        public void AddInMemory(Playlists playlist)
        {
            //Verificando se existem registros salvos com a KeyOptions na memoryCache
            _playlistTemp = getInMemory();
            
            //Se retornar dados - Foreach para obter playlist mais atualizada
            if (_playlistTemp!=null)
            {
                foreach (var item in _playlistTemp)
                {
                    _playlist.Add(item);
                }
            }
            //adicionando item de playlist do formulário a playlist 
            _playlist.Add(playlist);

            //salvando playlist Atualizada no memoryCache
            _memoryCache.Set<List<Playlists>>(keyOptions, _playlist, _memoryOptions);

        }

        public List<Playlists> getInMemory()
        {
            //Obtendo lista que está salva no memoryCache
            List<Playlists> list;
            list = _memoryCache.Get <List<Playlists>>(keyOptions);
            return list;
        }

        public void UpdateInMemory(int id, Playlists playlist)
        {
            List<Playlists> list;
           //Obtendo lista da memória
            list = _memoryCache.Get<List<Playlists>>(keyOptions);
            //filtrando na lista pelo Id
            var item = list[id];

            //Alterando propriedades de acordo com o que foi passado em parametro
                item = playlist;

            //Atualiando item na playlist e salvando em memória
            AddInMemory(item);

        }

        public void RemoveInMemory(Guid id)
        {

        }


        #endregion

        #region Metodos para manipulação de Playlist

       
        //Efetuando Crud em Lista - Tempo de execução - Analisar como funciona depois que é efetuado o postback do webforms.
        public void Insere(Playlists entidade)
        {

            _playlist.Add(entidade);
        }

        public List<Playlists> ListarTodos()
        {

            return _playlist;
        }

        public void Atualizar(int id, Playlists entidade)
        {
            _playlist[id] = entidade;
        }

        public Playlists consultar(int id)
        {
           return _playlist[id];
        }


        //Por se tratar de uma lista e o Indice começar em 0, deve-se utilizar o proximo para obter sempre a opção atual do elemento.
        //Não foi utilizado pois a ideia era utilizar o banco de dados.
        public int Proximo()
        {
            return _playlist.Count;
        }
        #endregion
    }
}
