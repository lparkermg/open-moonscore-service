using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.ScoreRepo
{
    public class InMemoryScoreRepository : IScoreRepository
    {
        public Score Add(string scoreType, Guid gameId, string username, float score)
        {
            throw new NotImplementedException();
        }

        public List<Score> GetScoresByGame(Guid gameId, string orderBy, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
