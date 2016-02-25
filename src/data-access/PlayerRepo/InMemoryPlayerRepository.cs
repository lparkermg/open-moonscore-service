using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_access.Exceptions.Player;
using entities;

namespace data_access.PlayerRepo
{
    public class InMemoryPlayerRepository : IPlayerRepository
    {
        private Dictionary<string,Player> _repo = new Dictionary<string, Player>();
        public Player Add(string username, string displayName, string passwordHash)
        {
            if(_repo.ContainsKey(username))
                throw new PlayerAlreadyExistsException("Player already exists.");
            var player = new Player(displayName, username, passwordHash);
            _repo.Add(username,player );

            return player;
        }

        public Player Get(string username)
        {
            if(!_repo.ContainsKey(username))
                throw new PlayerNotFoundException("Player not found in database");

            return _repo[username];
        }

        public List<Player> GetAll(bool onlyActive)
        {
            return GetAllThePlayers(onlyActive);
        }

        public void Deactivate(string username, string email, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public void Activate(string username, string email, Guid token)
        {
            throw new NotImplementedException();
        }

        public void Delete(string username, string email, string passwordHash)
        {
            throw new NotImplementedException();
        }

        private List<Player> GetAllThePlayers(bool onlyActive)
        {
            var values = _repo.Values;

            if (onlyActive)
                return values.Where(player => player.Deactivated == false).ToList();
            else
                return values.ToList();
        }
    }
}
