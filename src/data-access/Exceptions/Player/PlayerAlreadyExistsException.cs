using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Exceptions.Player
{
    public class PlayerAlreadyExistsException : Exception
    {
        public PlayerAlreadyExistsException()
        {
        }

        public PlayerAlreadyExistsException(string message) : base(message)
        {
        }

        public PlayerAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PlayerAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
