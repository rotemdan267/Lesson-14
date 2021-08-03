using System;
using System.Runtime.Serialization;

namespace Lesson_14
{
    [Serializable]
    internal class MessageToClientException : Exception
    {
        public MessageToClientException()
        {
        }

        public MessageToClientException(string message) : base(message)
        {
        }

        public MessageToClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MessageToClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}