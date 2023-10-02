using GameStore.API.Entity;
using GameStore.API.Entity.DTO;

namespace GameStore.API.Service
{
    public interface IGameService
    {
        Task<IEnumerable<Game[]>> getAllGames();
        Task<Game> getOne(string name);
        Task deleteGame(Guid id);
        Task<Game> createGame(CreateGameDTO createGame);
        Task updateGame(UpdateGameDTO newGame);
    }
}