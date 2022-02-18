using System;
using System.Runtime.Serialization;

namespace Teste.Back.End.Correios.Application.Exceptions
{
    [Serializable]
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} ({key}) não foi encontrado")
        {

        }
        public NotFoundException()
        {

        }
        public NotFoundException(string message)
            : base(message)
        {
        }
        public NotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected NotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
