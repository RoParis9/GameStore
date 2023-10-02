using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameStore.API.Entity;
using GameStore.API.Entity.DTO;
using GameStore.API.Repository;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GameStore.API.Service
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;
        public GameService(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public async Task<Game> createGame(CreateGameDTO createGame)
        {
            var newGame = _mapper.Map<Game>(createGame);
            await _gameRepository.createGame(newGame);
            return newGame;
        }

        public async Task deleteGame(Guid id)
        {
            await _gameRepository.deleteGame(id);
        }

        public async Task<IEnumerable<Game[]>> getAllGames()
        {
            return await _gameRepository.getAllGames();
        }

        public async Task<Game> getOne(string name)
        {
            return await _gameRepository.getOneGame(name);
        }

        public async Task updateGame(UpdateGameDTO newGame)
        {
            var updateGame = _mapper.Map<Game>(newGame);
            await _gameRepository.updateGame(updateGame);
            return;
        }
    }
}