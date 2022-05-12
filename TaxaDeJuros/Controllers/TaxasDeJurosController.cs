using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaxaDeJuros;

namespace TaxasDeJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxasDeJurosController : ControllerBase
    {

        private readonly ILogger<TaxasDeJurosController> _logger;

        public TaxasDeJurosController(ILogger<TaxasDeJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int TaxasDeJuros()
        {
            int taxa = 1;
            return taxa;
        }
    }
}
