using System;
using System.Runtime.Serialization;

namespace w600_download_tool
{
    internal class W600Exception : Exception
    {
        public W600Exception()
        {
        }

        public W600Exception(string message) : base(message)
        {
        }

        public W600Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected W600Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}