using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using System.Threading.Tasks;

namespace Atendimento.Cliente.Bff.For.Order.Domain.Contracts.Repository.Http
{
    public interface ICorreiosRepository
    {
        public Task<Address> GetAddressByZipCodeAsync(string zipCode);
    }
}
