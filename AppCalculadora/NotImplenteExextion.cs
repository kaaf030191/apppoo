using System;
using System.Runtime.Serialization;

namespace AppCalculadora
{
    [Serializable]
    internal class NotImplenteExextion : Exception
    {
        public NotImplenteExextion()
        {
        }

        public NotImplenteExextion(string message) : base(message)
        {
        }

        public NotImplenteExextion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplenteExextion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}