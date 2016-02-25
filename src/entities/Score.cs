using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Score
    {
        public Guid Id { get; private set; }
        public string ScoreType { get; private set; }
        public Guid GameId { get; private set; }
        public string Username { get; private set; }
        public float UserScore { get; private set; }
        public DateTime Created { get; private set; }

        public Score(string scoreType, Guid gameId, string username, float userScore)
        {
            ScoreType = scoreType;
            GameId = gameId;
            Username = username;
            UserScore = userScore;
            Created = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}
