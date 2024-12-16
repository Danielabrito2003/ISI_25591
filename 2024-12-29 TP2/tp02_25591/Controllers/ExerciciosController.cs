using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GestaoReceitasExercicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExerciciosController : ControllerBase
    {
        private static List<Exercicio> exercicios = new List<Exercicio>
        {
            new Exercicio { Id = 1, Nome = "Flexões" },
            new Exercicio { Id = 2, Nome = "Corrida 5km" }
        };

        // GET: api/exercicios
        [HttpGet]
        public ActionResult<IEnumerable<Exercicio>> GetExercicios()
        {
            return Ok(exercicios);
        }

        // GET: api/exercicios/{id}
        [HttpGet("{id}")]
        public ActionResult<Exercicio> GetExercicio(int id)
        {
            var exercicio = exercicios.FirstOrDefault(e => e.Id == id);
            if (exercicio == null)
            {
                return NotFound("Exercício não encontrado.");
            }
            return Ok(exercicio);
        }

        // POST: api/exercicios
        [HttpPost]
        public ActionResult AddExercicio([FromBody] Exercicio novoExercicio)
        {
            if (string.IsNullOrWhiteSpace(novoExercicio.Nome))
            {
                return BadRequest("O nome do exercício não pode estar vazio.");
            }

            // Gerar novo ID automaticamente
            novoExercicio.Id = exercicios.Any() ? exercicios.Max(e => e.Id) + 1 : 1;
            exercicios.Add(novoExercicio);
            return Ok("Exercício adicionado com sucesso.");
        }

        // PUT: api/exercicios/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateExercicio(int id, [FromBody] Exercicio exercicioAtualizado)
        {
            var exercicioExistente = exercicios.FirstOrDefault(e => e.Id == id);
            if (exercicioExistente == null)
            {
                return NotFound("Exercício não encontrado.");
            }

            if (string.IsNullOrWhiteSpace(exercicioAtualizado.Nome))
            {
                return BadRequest("O nome do exercício não pode estar vazio.");
            }

            // Atualizar os dados do exercício
            exercicioExistente.Nome = exercicioAtualizado.Nome;
            return Ok("Exercício atualizado com sucesso.");
        }

        // DELETE: api/exercicios/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteExercicio(int id)
        {
            var exercicioExistente = exercicios.FirstOrDefault(e => e.Id == id);
            if (exercicioExistente == null)
            {
                return NotFound("Exercício não encontrado.");
            }

            exercicios.Remove(exercicioExistente);
            return Ok("Exercício removido com sucesso.");
        }

        // Modelo para representar um exercício
        public class Exercicio
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
