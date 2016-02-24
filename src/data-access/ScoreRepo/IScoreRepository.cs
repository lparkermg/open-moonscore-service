using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data_access.ScoreRepo
{
    public interface IScoreRepository
    {
        Score Add(string scoreType, Guid gameId, string username, float score);
        List<Score> GetScoresByGame(Guid gameId, string orderBy,int amount);

    }
}
