using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Score
    {
        public string ScoreType { get; private set; }
        public string GameName { get; private set; }
        public string Username { get; private set; }
        public float UserScore { get; private set; }
        public DateTime Created { get; private set; }

        public Score(string scoreType, string gameName, string username, float userScore, DateTime created)
        {
            ScoreType = scoreType;
            GameName = gameName;
            Username = username;
            UserScore = userScore;
            Created = created;
        }
    }
}
