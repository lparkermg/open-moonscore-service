using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Game
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        public Game(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public Game(Guid id, string name, DateTime created, DateTime updated)
        {
            Id = id;
            Name = name;
            Created = created;
            Updated = updated;
        }

        public void UpdateName(string name)
        {
            Name = name;
            Updated = DateTime.Now;
        }
    }
}
