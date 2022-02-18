using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using System.Threading.Tasks;

namespace Teste.Back.End.Correios.Domain.Contracts.Repository.Persistence
{
    public interface ICorreiosSqlServer
    {
        public Task<bool> SaveAddressAsync(Address address);
    }
}
