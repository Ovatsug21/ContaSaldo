using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transacao_API.Models;
using Transacao_API.Services;

namespace Transacao_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacoesController : ControllerBase
    {

        private readonly TransacoesServices _transacoesServices;

        public TransacoesController(TransacoesServices transacoesServices)
        {
            _transacoesServices = transacoesServices;
        }

        [HttpPost]
        public async Task<Transacao> PostTransacao(Transacao transacao)
        {
            await _transacoesServices.CreateAsync(transacao);

            return transacao;
        }
    }
}
