using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class AnswerController : Controller
    {
        private SchoolContext _context;

        public AnswerController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(AnswerDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var answer = new Answer();
            answer.Observation = dto.Observation;
            answer.StudentId = dto.StudentId;
            answer.QuestionId = dto.QuestionId;
            answer.Score = dto.Score;
            answer.Answers = dto.Answers;

            _context.Answers.Add(answer);
            _context.SaveChanges();

            return Ok(answer);
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, AnswerDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var answer = _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
            if (answer == null)
            {
                return NotFound();
            }

            answer.Observation = dto.Observation;
            answer.StudentId = dto.StudentId;
            answer.QuestionId = dto.QuestionId;
            answer.Score = dto.Score;
            answer.Answers = dto.Answers;

            _context.Answers.Update(answer);
            _context.SaveChanges();

            return Ok(answer);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var answer = _context.ObterListaAnswer();

            return Ok(answer);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var answer = _context.Answers.FirstOrDefault(x => x.Id == id);

            if (answer == null)
            {
                return NotFound();
            }

            return Ok(answer);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var answer = _context.Answers.FirstOrDefault(x => x.Id == id);

            if (answer == null)
            {
                return NotFound();
            }
            else
            {
                _context.Answers.Remove(answer);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}
