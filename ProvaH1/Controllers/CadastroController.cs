using Microsoft.AspNetCore.Mvc;
using ProvaH1.Models;
using ProvaH1.Repositorios;
namespace ProvaH1.Controllers
{
    [ApiController]
    [Route("Api[controller]")]
    public class CadastroController : ControllerBase
    {
        public readonly ICadastrorRepository _Cadastro;
        public CadastroController(ICadastrorRepository Cadastro)
        {
            _Cadastro = Cadastro;
        }

        [HttpPost]
        public IActionResult Cadastrar(Cadastro cadastro)
        {
            Cadastro EleitorExistente = _Cadastro.BuscarPorCPF(cadastro.CPF);
            if (EleitorExistente != null)
            {
                return BadRequest("Eleitor já cadastrado.");
            }
            _Cadastro.Adicionar(cadastro);
            return Created("", cadastro);
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_Cadastro.ListarCadastro);
        }

    }
}


