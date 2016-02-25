using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.GameRepo
{
    public interface IGameRepository
    {
        Game Add(string name);
        Game Get(Guid id);
    }
}
