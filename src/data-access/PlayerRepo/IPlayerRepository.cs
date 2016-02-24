using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.PlayerRepo
{
    public interface IPlayerRepository
    {
        void Add(Player player);
        Player Get(string username);
        Player GetAll(bool onlyActive);
        void Deactivate(string username, string email, string passwordHash);
        void Activate(string username, string email, Guid token);
        void Delete(string username, string email, string passwordHash);
    }
}
