using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Back.End.Correios.Api.DTO.Correios;
using Teste.Back.End.Correios.Application.Features.Correios.Queries.GetAddressByZipCode;

namespace Teste.Back.End.Correios.Api.Controllers
{
    /// <summary>
    /// CorreiosController
    /// </summary>
    [ApiController]
    [Route("teste/desenvolvedor/v1/correios/")]
    public class CorreiosController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public CorreiosController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("cep/{cep}")]
        public async Task<IActionResult> GetByZipCode([FromRoute] string cep)
        {

            var getAddressByZipCodeAsyncQuery = new GetAddressByZipeCodeAsyncQuery
            {
                Cep = cep
            };

            var result = _mediator.Send(getAddressByZipCodeAsyncQuery);

            return Ok(_mapper.Map<AddressResponse>(await result));
        }
    }
}
