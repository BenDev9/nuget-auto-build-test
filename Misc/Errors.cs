using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChartsApi.Errors
{

    [Serializable]
    public class ClassChartsAPIException : Exception
    {
        public ClassChartsAPIException() { }
        public ClassChartsAPIException(string message) : base(message) { }
        public ClassChartsAPIException(string message, Exception inner) : base(message, inner) { }
        protected ClassChartsAPIException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class ClassChartsAPIParsingException : Exception
    {
        public ClassChartsAPIParsingException() { }
        public ClassChartsAPIParsingException(string message) : base(message) { }
        public ClassChartsAPIParsingException(string message, Exception inner) : base(message, inner) { }
        protected ClassChartsAPIParsingException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class ClassChartsAPIAuthenticationError : Exception
    {
        public ClassChartsAPIAuthenticationError() { }
        public ClassChartsAPIAuthenticationError(string message) : base(message) { }
        public ClassChartsAPIAuthenticationError(string message, Exception inner) : base(message, inner) { }
        protected ClassChartsAPIAuthenticationError(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
