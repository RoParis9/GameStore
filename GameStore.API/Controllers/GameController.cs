using GameStore.API.Entity;
using GameStore.API.Entity.DTO;
using GameStore.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game[]>>> getAllGames()
        {
            try
            {
                var games = await _gameService.getAllGames();
                return Ok(games);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"An error occurred on the server");
            }
        }
        [HttpGet]
        public async Task<ActionResult<Game>> getOneGame([FromBody] string name)
        {
            var singleGame = await _gameService.getOne(name);
            return Ok(singleGame);
        }
        [HttpDelete]
        public async Task<ActionResult> deleteOneGame([FromBody] Guid id)
        {
            await _gameService.deleteGame(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> createOneGame(CreateGameDTO newGame)
        {
            await _gameService.createGame(newGame);
            return Ok();
        }
        [HttpPatch]
        public async Task<ActionResult> updateOneGame(UpdateGameDTO newGame)
        {
            await _gameService.updateGame(newGame);
            return Ok();
        }

    }
}