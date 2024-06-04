using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Encryption_and_decryption_csharp.services.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Encryption_and_decryption_csharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DescriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DescriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Realiza a criptografia de um texto 
        /// </summary>
        /// <returns>Criptografia</returns>
        /// <response code="200">200 Sucesso</response>
        /// <response code="400">400 Erro</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EncryptAndDecryptResult))]
        [HttpPost("Encript")]
        public async Task<IActionResult> Encrypt([FromBody] EncryptAndDecryptCommand values)
        {
            var result = await _mediator.Send(values);
            return Ok(result);
        }
    }
}