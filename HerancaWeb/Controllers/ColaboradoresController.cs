// Controllers/ColaboradoresController.cs
using Microsoft.AspNetCore.Mvc;
using ColaboradorAPI.Models;

namespace Colaboradores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradoresController : ControllerBase
    {
        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] Colaborador colaborador)
        {
            if (string.IsNullOrWhiteSpace(colaborador.Nome) ||
                colaborador.Idade == 0 ||
                string.IsNullOrWhiteSpace(colaborador.Cargo) ||
                colaborador.Salario == 0)
            {
                return BadRequest("Todos os campos devem ser preenchidos.");
            }
                
            // Aqui você poderia salvar no banco de dados
            return Ok($"Colaborador {colaborador.Nome} cadastrado com sucesso!");
        }

    }
}
