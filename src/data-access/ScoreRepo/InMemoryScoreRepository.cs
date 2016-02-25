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
        private Dictionary<Guid, Score> _repo = new Dictionary<Guid, Score>(); 
        public Score Add(string scoreType, Guid gameId, string username, float score)
        {
            var scoreEntered = false;
            Score newScore = null;
            while (!scoreEntered)
            {
                newScore = new Score(scoreType,gameId,username,score);
                if (!_repo.ContainsKey(newScore.Id))
                    scoreEntered = true;
            }

            return newScore;
        }

        public List<Score> GetScoresByGame(Guid gameId, string orderBy, int amount = 10)
        {
            return ScoreHelper(gameId, orderBy, amount);
        }

        private List<Score> ScoreHelper(Guid gameId, string orderBy, int amount)
        {
            var scores = new List<Score>();

            switch(orderBy)
            {
                case ("DSC"):
                    return
                        _repo.Values.OrderByDescending(gm => gm.UserScore)
                            .Where(gm => gm.GameId == gameId)
                            .Take(amount).ToList();
                case ("ASC"):
                    return
                        _repo.Values.OrderBy(gm => gm.UserScore)
                            .Where(gm => gm.GameId == gameId)
                            .Take(amount).ToList();
                default:
                    return
                        _repo.Values.OrderBy(gm => gm.UserScore)
                            .Where(gm => gm.GameId == gameId)
                            .Take(amount).ToList();
            }
        }
    }
}
