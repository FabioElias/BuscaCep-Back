using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using MediatR;

namespace Teste.Back.End.Correios.Application.Features.Correios.Queries.GetAddressByZipCode
{
    public class GetAddressByZipeCodeAsyncQuery : IRequest<Address>
    {
        public string Cep;
    }
}
