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
        void Add(Score score);
        List<Score> GetScoresByGame(string gameName, int amount);

    }
}
