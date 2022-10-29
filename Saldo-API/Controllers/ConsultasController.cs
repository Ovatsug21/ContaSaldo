using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saldo_API.Models;
using Saldo_API.Services;

namespace Saldo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private readonly ConsultasServices _consultasServices;

        public ConsultasController(ConsultasServices consultasServices)
        {
            _consultasServices = consultasServices;
        }

        [HttpGet]
        public async Task<ActionResult> GetByIdAsync(int id)

        {
            var result = await _consultasServices.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
