using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using Teste.Back.End.Correios.Domain.Contracts.Repository.Persistence;

namespace Teste.Back.End.Correios.Repository.Persistence
{
    public class CorreiosSqlServer : ICorreiosSqlServer
    {
        private readonly IDbConnection _connection;

        public CorreiosSqlServer(IDbConnection connection)
        {
            _connection = connection;
        }
        public async Task<bool> SaveAddressAsync(Address address)
        {
            try
            {
                var affectedRows = await _connection.ExecuteAsync(CorreioSql.Create, new
                {
                    address.City,
                    address.Street,
                    address.Ddd,
                    address.Ibge,
                    address.Complement,
                    address.Siafi,
                    address.Gia,
                    address.Neighborhood,
                    address.State
                });
                return affectedRows == 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
