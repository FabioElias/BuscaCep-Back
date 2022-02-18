using System;
using System.Runtime.Serialization;

namespace Teste.Back.End.Correios.Application.Exceptions
{
    [Serializable]
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException(string name, object key) : base($"{name} ({key}) não foi encontrado")
        {

        }
        public UnauthorizedException()
        {

        }
        public UnauthorizedException(string message)
            : base(message)
        {
        }
        public UnauthorizedException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected UnauthorizedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
