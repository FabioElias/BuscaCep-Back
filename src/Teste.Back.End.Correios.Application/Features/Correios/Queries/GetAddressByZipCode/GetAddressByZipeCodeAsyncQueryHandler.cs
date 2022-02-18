using Atendimento.Cliente.Bff.For.Order.Domain.Contracts.Repository.Http;
using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Teste.Back.End.Correios.Domain.Contracts.Repository.Persistence;

namespace Teste.Back.End.Correios.Application.Features.Correios.Queries.GetAddressByZipCode
{
    public class GetAddressByZipeCodeAsyncQueryHandler : IRequestHandler<GetAddressByZipeCodeAsyncQuery, Address>
    {
        private readonly ICorreiosRepository _correiosRepository;
        private readonly ICorreiosSqlServer _correiosSqlServe;

        public GetAddressByZipeCodeAsyncQueryHandler(ICorreiosRepository correiosRepository, ICorreiosSqlServer correiosSqlServe)
        {
            _correiosRepository = correiosRepository;
            _correiosSqlServe = correiosSqlServe;
        }

        public async Task<Address> Handle(GetAddressByZipeCodeAsyncQuery request, CancellationToken cancellationToken)
        {
            var correiosResponse = await _correiosRepository.GetAddressByZipCodeAsync(request.Cep);
            //var saveAddress =await _correiosSqlServe.SaveAddressAsync(correiosResponse);

            return correiosResponse;
        }

    }
}
