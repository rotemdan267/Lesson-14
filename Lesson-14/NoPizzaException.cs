using System;
using System.Runtime.Serialization;

namespace Lesson_14
{
    [Serializable]
    internal class NoPizzaException : Exception
    {
        public NoPizzaException()
        {
        }

        public NoPizzaException(string message) : base(message)
        {
        }

        public NoPizzaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoPizzaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}