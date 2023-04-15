using Escola.Dto;
using Escola.Models;
using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        // exercicio 8
        [HttpGet]
        public IActionResult Listar([FromQuery] string? nome)
        {
            var repository = new AlunoRepository();
            var alunos = repository.ListarAlunos(nome);
           
            return Ok(alunos);
        }

        // exercicio 9
        [HttpGet]
        [Route("{id}")]
        public IActionResult Obter([FromRoute] int id) 
        {
            if (id <= 0) 
            {
                return BadRequest("ID devo maior que zero");
            }

            var repository = new AlunoRepository();
            var alunos = repository.ObterAlunos(id);

            if (alunos == null) 
                return NotFound();

            return Ok(alunos);
        }

        // exercicio 10
        [HttpPost]
        public IActionResult Criar([FromBody] CriarAlunoDto dto)
        {
            var repository = new AlunoRepository();
            var aluno = repository.CriarAluno(dto);
            return CreatedAtAction(nameof(AlunoController.Obter), new { id = aluno.Id, aluno });
        }

        // exercicio 11
        [HttpDelete]
        [Route("{ìd}")]
        public IActionResult Excluir([FromRoute]int id)
        {
            var repository = new AlunoRepository();
            repository.ExcluirAluno(id);

            return NoContent();
        }
    }
}
