using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using AutoMapper;
using Teste.Back.End.Correios.Api.DTO.Correios;

namespace Teste.Back.End.Correios.Api.Infra.Mapper.Profiles
{
    /// <summary>
    /// Classe de Mapeamento de Detalhes de Pedidos
    /// </summary>
    public class CorreiosProfile : Profile
    {
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public CorreiosProfile()
        {
            CreateMap<Address,AddressResponse >().ReverseMap();

        }
    }
}
