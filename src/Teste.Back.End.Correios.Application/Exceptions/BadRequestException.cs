﻿using System;
using System.Runtime.Serialization;

namespace Teste.Back.End.Correios.Application.Exceptions
{
    [Serializable]
    public class BadRequestException : ApplicationException
    {
        public BadRequestException()
        {

        }
        public BadRequestException(string message)
            : base(message)
        {
        }
        public BadRequestException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected BadRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
