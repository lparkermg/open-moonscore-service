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
        public DateTime Created { get; private set; }
        public DateTime LastUpdated { get; private set; }
        public bool Deactivated { get; private set; }
        public Guid? ReactivationToken { get; private set; }
        public DateTime? ReactivationSent { get; private set; }
        
        public Player(string displayName, string username, string passwordHash)
        {
            DisplayName = displayName;
            Username = username;
            PasswordHash = passwordHash;
            Created = DateTime.Now;
            LastUpdated = DateTime.Now;
            Deactivated = false;
            ReactivationToken = null;
            ReactivationSent = null;
        }

        public void UpdateDisplayName(string newName)
        {
            DisplayName = newName;
            LastUpdated = DateTime.Now;
        }

        public void UpdatePasswordHash(string newPassword)
        {
            PasswordHash = newPassword;
            LastUpdated = DateTime.Now;
        }

        public void Deactivate()
        {
            Deactivated = true;
            ReactivationToken = Guid.NewGuid();
        }

        public Guid? SendActivationToken()
        {
            ReactivationSent = DateTime.Now;
            return ReactivationToken;

        }
    }
}
