using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class QuestionController : Controller
    {
        private SchoolContext _context;

        public QuestionController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(QuestionDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var question = new Question();
            question.Weight = dto.Weight;
            question.QuizId = dto.QuizId;
            question.Enunciation = dto.Enunciation;

            _context.Questions.Add(question);
            _context.SaveChanges();

            return Ok(question);
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, QuestionDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var question = _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
            if (question == null)
            {
                return NotFound();
            }

            question.Weight = dto.Weight;
            question.QuizId = dto.QuizId;
            question.Enunciation = dto.Enunciation;

            _context.Questions.Update(question);
            _context.SaveChanges();

            return Ok(question);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var question = _context.ObterListaQuestion();

            return Ok(question);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == id);

            if (question == null)
            {
                return NotFound();
            }
            else
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}
