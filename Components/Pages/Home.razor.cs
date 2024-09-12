using Gamestore.Frontend.Clients;
using Gamestore.Frontend.Models;

namespace Gamestore.Frontend.Components.Pages
{
    public partial class Home
    {
        private readonly GamesClient client = new();
        private GameSummary[]? games;

        protected override void OnInitialized()
        {
            games = client.GetGames();
        }
    }
}
