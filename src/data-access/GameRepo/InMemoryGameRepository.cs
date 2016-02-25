using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_access.Exceptions.Game;
using entities;

namespace data_access.GameRepo
{
    public class InMemoryGameRepository : IGameRepository
    {
        private Dictionary<Guid,Game> _repo = new Dictionary<Guid, Game>(); 

        public Game Add(string name)
        {
            var newGame = new Game(name);
            if (_repo.ContainsKey(newGame.Id))
                throw new GameAlreadyExistsException("Game Id already exists.");

            _repo.Add(newGame.Id,newGame);

            return newGame;
        }

        public Game Get(Guid id)
        {
            if(!_repo.ContainsKey(id))
                throw new GameNotFoundException("Game Id not found.");

            return _repo[id];
        }
    }
}
