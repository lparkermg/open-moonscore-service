using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Exceptions.Game
{
    public class GameNotFoundException : Exception
    {
        public GameNotFoundException()
        {
        }

        public GameNotFoundException(string message) : base(message)
        {
        }

        public GameNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GameNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
