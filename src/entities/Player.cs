using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Player
    {
        public string DisplayName { get; private set; }
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }

        public Player(string displayName, string username, string passwordHash)
        {
            DisplayName = displayName;
            Username = username;
            PasswordHash = passwordHash;
        }
    }
}
