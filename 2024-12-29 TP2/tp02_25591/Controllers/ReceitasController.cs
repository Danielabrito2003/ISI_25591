using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GestaoReceitasExercicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceitasController : ControllerBase
    {
        private static List<Receita> receitas = new List<Receita>
        {
            new Receita { Id = 1, Nome = "Sopa de Legumes" },
            new Receita { Id = 2, Nome = "Frango Assado com Batatas" }
        };

        // GET: api/receitas
        [HttpGet]
        public ActionResult<IEnumerable<Receita>> GetReceitas()
        {
            return Ok(receitas);
        }

        // GET: api/receitas/{id}
        [HttpGet("{id}")]
        public ActionResult<Receita> GetReceita(int id)
        {
            var receita = receitas.FirstOrDefault(r => r.Id == id);
            if (receita == null)
            {
                return NotFound("Receita não encontrada.");
            }
            return Ok(receita);
        }

        // POST: api/receitas
        [HttpPost]
        public ActionResult AddReceita([FromBody] Receita novaReceita)
        {
            if (string.IsNullOrWhiteSpace(novaReceita.Nome))
            {
                return BadRequest("O nome da receita não pode estar vazio.");
            }

            // Gerar novo ID automaticamente
            novaReceita.Id = receitas.Any() ? receitas.Max(r => r.Id) + 1 : 1;
            receitas.Add(novaReceita);
            return Ok("Receita adicionada com sucesso.");
        }

        // PUT: api/receitas/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateReceita(int id, [FromBody] Receita receitaAtualizada)
        {
            var receitaExistente = receitas.FirstOrDefault(r => r.Id == id);
            if (receitaExistente == null)
            {
                return NotFound("Receita não encontrada.");
            }

            if (string.IsNullOrWhiteSpace(receitaAtualizada.Nome))
            {
                return BadRequest("O nome da receita não pode estar vazio.");
            }

            // Atualizar os dados da receita
            receitaExistente.Nome = receitaAtualizada.Nome;
            return Ok("Receita atualizada com sucesso.");
        }

        // DELETE: api/receitas/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteReceita(int id)
        {
            var receitaExistente = receitas.FirstOrDefault(r => r.Id == id);
            if (receitaExistente == null)
            {
                return NotFound("Receita não encontrada.");
            }

            receitas.Remove(receitaExistente);
            return Ok("Receita removida com sucesso.");
        }

        // Modelo para representar uma receita
        public class Receita
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
