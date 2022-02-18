using Atendimento.Cliente.Bff.For.Order.Domain.Contracts.Repository.Http;
using Atendimento.Cliente.Bff.For.Order.Repository.Http;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Teste.Back.End.Correios.Application.Features.Correios.Queries.GetAddressByZipCode;
using Teste.Back.End.Correios.Domain.Contracts.Repository.Persistence;
using Teste.Back.End.Correios.Repository.Persistence;

namespace Atendimento.Cliente.Bff.For.Order.IoC.Extensions
{
    public static class DependecyInjectionExtension
    {
        public static void ConfigureDependecyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetEntryAssembly());
            services.AddMediatR(typeof(GetAddressByZipeCodeAsyncQueryHandler).Assembly);

            services.AddScoped<ICorreiosRepository, CorreiosRepository>();
            services.AddScoped<ICorreiosSqlServer, CorreiosSqlServer>();
        }

        public static void ConfigureConnectionString(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IDbConnection>(db => new SqlConnection() { ConnectionString = connectionString });
        }
    }
}
