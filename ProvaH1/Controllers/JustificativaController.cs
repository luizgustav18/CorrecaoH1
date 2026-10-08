using Microsoft.AspNetCore.Mvc;
using ProvaH1.Models;
using ProvaH1.Repositorios;
namespace ProvaH1.Controllers
{
    [ApiController]
    [Route("Api[controller]")]
    public class JustificativaController : ControllerBase
    {
        public readonly IJustificativaRpository _Justificativa;
        public JustificativaController(IJustificativaRpository justificativaRepository)
        {
            _Justificativa = justificativaRepository;
        }

        [HttpPost]
        public IActionResult CadJustificativa(Justificativa justificativa)
        {
            var EleitorExistente = _Justificativa.BuscarPorCPF(justificativa.CPF);
            if (EleitorExistente != null)
            {
                return BadRequest("Eleitor já cadastrado.");
            }
            _Justificativa.Adicionar(justificativa);
            return Created("", justificativa);
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_Justificativa.ListarJustificativas);
        }
        
    }
}
