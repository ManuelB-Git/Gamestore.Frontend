using System;
using Gamestore.Frontend.Models;

namespace Gamestore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new GameSummary
        {
            Id = 1,
            Name = "The Witcher 3: Wild Hunt",
            Genre = "RPG",
            Price = 29.99m,
            ReleaseDate = new DateTime(2015, 5, 19),
        },
        new GameSummary
        {
            Id = 2,
            Name = "Cyberpunk 2077",
            Genre = "RPG",
            Price = 59.99m,
            ReleaseDate = new DateTime(2020, 12, 10),
        },
        new GameSummary
        {
            Id = 3,
            Name = "The Elder Scrolls V: Skyrim",
            Genre = "RPG",
            Price = 39.99m,
            ReleaseDate = new DateTime(2011, 11, 11),
        },
        new GameSummary
        {
            Id = 4,
            Name = "Grand Theft Auto V",
            Genre = "Action",
            Price = 29.99m,
            ReleaseDate = new DateTime(2013, 9, 17),
        },
        new GameSummary
        {
            Id = 5,
            Name = "Red Dead Redemption 2",
            Genre = "Action",
            Price = 39.99m,
            ReleaseDate = new DateTime(2018, 10, 26),
        },
    ];

    public GameSummary[] GetGames() => [.. games];
}
