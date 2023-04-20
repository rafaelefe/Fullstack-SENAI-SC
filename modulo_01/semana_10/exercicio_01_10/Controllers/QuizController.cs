using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class QuizController : Controller
    {
        private SchoolContext _context;

        public QuizController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(QuizDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quiz = new Quiz();
            quiz.Title = dto.Title;
            quiz.DisciplineId = dto.DisciplineId;
            quiz.DataOpen = dto.DataOpen;
            quiz.DateClose = dto.DateClose;

            _context.Quizs.Add(quiz);
            _context.SaveChanges();

            return Ok(quiz);
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, QuizDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var quiz = _context.Quizs.FirstOrDefault(x => x.Id.Equals(id));
            if (quiz == null)
            {
                return NotFound();
            }

            quiz.Title = dto.Title;
            quiz.DisciplineId = dto.DisciplineId;
            quiz.DataOpen = dto.DataOpen;
            quiz.DateClose = dto.DateClose;

            _context.Quizs.Update(quiz);
            _context.SaveChanges();

            return Ok(quiz);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var quiz = _context.ObterListaQuiz();

            return Ok(quiz);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var quiz = _context.Quizs.FirstOrDefault(x => x.Id == id);

            if (quiz == null)
            {
                return NotFound();
            }

            return Ok(quiz);
        }   

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var quiz = _context.Quizs.FirstOrDefault(x => x.Id == id);

            if (quiz == null)
            {
                return NotFound();
            }
            else
            {
                _context.Quizs.Remove(quiz);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}
