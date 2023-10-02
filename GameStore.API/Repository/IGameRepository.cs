using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.API.Entity;
using GameStore.API.Entity.DTO;

namespace GameStore.API.Repository
{
    public interface IGameRepository
    {
        Task<Game> createGame(Game createGame);
        Task deleteGame(Guid id);
        Task updateGame(Game game);
        Task<Game> getOneGame(string name);
        Task<IEnumerable<Game[]>> getAllGames();
    }
}