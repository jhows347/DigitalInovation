using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestePlaylist.DataInitialize;
using TestePlaylist.Repository;

namespace TestePlaylist
{
    public partial class Detalhes : System.Web.UI.Page
    {
        private PlaylistRepository playlistRepository;
         protected void Page_Load(object sender, EventArgs e)
        {
            playlistRepository = new PlaylistRepository();
            DetalhesPlaylist.DataSource = playlistRepository.getInMemory();
            DetalhesPlaylist.DataBind();

        }
    }
}