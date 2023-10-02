using GameStore.API.Data;
using GameStore.API.Entity;
using GameStore.API.Entity.DTO;
using Microsoft.EntityFrameworkCore;

namespace GameStore.API.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly DataContext _dbContext;
        
        public GameRepository(DataContext dataContext)
        {
            _dbContext = dataContext; 
        }

        public async Task<Game> createGame(Game createGame)
        {
            await _dbContext.Games.AddAsync(createGame);
            return createGame;
            
        }

        public async Task deleteGame(Guid id)
        {
           var game = await _dbContext.Games.FindAsync(id);

           if(game == null){
            return ;
           }
           _dbContext.Games.Remove(game);
           await _dbContext.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Game[]>> getAllGames()
        {
            var games = await _dbContext.Games.ToListAsync();

            var gameArray = games.Select(game => new Game[] {game});

            return gameArray;
        }

        public async Task<Game> getOneGame(string name)
        {
            return await _dbContext.Games.FirstOrDefaultAsync(u => u.Name == name);
        }

        public async Task updateGame(Game gameDTO)
        {
            _dbContext.Games.Update(gameDTO);
            await _dbContext.SaveChangesAsync();
            return;
        }
    }
}