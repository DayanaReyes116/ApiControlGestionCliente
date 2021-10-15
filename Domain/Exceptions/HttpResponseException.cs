using System;
using System.Runtime.Serialization;

namespace Domain.Exceptions
{
    [Serializable]
    public  class HttpResponseException : Exception
    {
        public HttpResponseException()
        {
            // ...
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // ...
        }

        public int Status { get; set; } = 500;
        public object Value { get; set; }
    }
}
