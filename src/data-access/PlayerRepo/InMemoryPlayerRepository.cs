using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.PlayerRepo
{
    public class InMemoryPlayerRepository : IPlayerRepository
    {
        public Player Add(string username, string displayName, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Player Get(string username)
        {
            throw new NotImplementedException();
        }

        public Player GetAll(bool onlyActive)
        {
            throw new NotImplementedException();
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
    }
}
