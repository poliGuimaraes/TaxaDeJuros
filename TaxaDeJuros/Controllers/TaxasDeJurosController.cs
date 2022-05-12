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
        public IEnumerable<TaxasDeJurosResponse> TaxasDeJuros()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new TaxasDeJurosResponse
            {
                TaxasDeJuros = "A taxa de juros atual é de: 1 % ao mês!"
            })
            .ToArray();
        }
    }
}
