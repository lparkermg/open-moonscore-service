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
        public Player Add(string username, string displayName, string passwordHash,string email)
        {
            if(_repo.ContainsKey(username))
                throw new PlayerAlreadyExistsException("Player already exists.");
            var player = new Player(displayName, username, passwordHash,email);
            _repo.Add(username,player );

            return player;
        }

        public Player Get(string username)
        {
            FindPlayer(username);

            return _repo[username];
        }

        public List<Player> GetAll(bool onlyActive)
        {
            return GetAllThePlayers(onlyActive);
        }

        public void Deactivate(string username, string email, string passwordHash)
        {
            FindPlayer(username);
            var player = _repo[username];
            if (player.Email == email && player.PasswordHash == passwordHash)
            {
                _repo[username].Deactivate();
            }
        }

        public void Activate(string username, string email, Guid token)
        {
            FindPlayer(username);
            var player = _repo[username];
            if (player.ReactivationSent == null)
                throw new InvalidOperationException("Player has not requested reactivation");

            //TODO: Make sure DateTime.Compare works properly.
            if (player.Email == email && player.ReactivationToken == token && DateTime.Compare(player.ReactivationSent.Value.AddMinutes(30),DateTime.Now) == -1)
            {
                _repo[username].Activate();
            }
        }

        public void Delete(string username, string email, string passwordHash)
        {
            FindPlayer(username);

            var player = _repo[username];
            if (player.Email == email && player.PasswordHash == passwordHash)
            {
                _repo.Remove(username);
            }
        }

        private List<Player> GetAllThePlayers(bool onlyActive)
        {
            var values = _repo.Values;

            if (onlyActive)
                return values.Where(player => player.Deactivated == false).ToList();
            else
                return values.ToList();
        }

        private void FindPlayer(string username)
        {
            if(!_repo.ContainsKey(username))
                throw new PlayerNotFoundException("Player doesn't exist.");
        }
    }
}
