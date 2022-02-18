using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Teste.Back.End.Correios.Application.Exceptions
{
    [Serializable]
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = (from validationError in validationResult.Errors
                                select validationError.ErrorMessage).ToList();
        }

        public ValidationException()
        {

        }
        public ValidationException(string message)
            : base(message)
        {
        }
        public ValidationException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected ValidationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
