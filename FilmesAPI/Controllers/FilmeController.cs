using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        // FromBody recebe a requisição pelo corpo da mesma, no caso Json {corpo}
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
        }
    }
}