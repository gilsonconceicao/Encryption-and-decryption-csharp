using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Encryption_and_decryption_csharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DescriptionController: ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDescriptions() 
        {
            return Ok(); 
        }
    }
}