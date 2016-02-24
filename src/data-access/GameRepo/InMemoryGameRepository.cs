using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.GameRepo
{
    public class InMemoryGameRepository : IGameRepository
    {
        public Game Add(string name)
        {
            throw new NotImplementedException();
        }

        public Game Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Activate(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Deactivate(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
