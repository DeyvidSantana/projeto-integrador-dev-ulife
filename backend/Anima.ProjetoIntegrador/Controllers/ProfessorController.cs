﻿using Anima.ProjetoIntegrador.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anima.ProjetoIntegrador.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet]
        public IActionResult ConsultarTurmasQuantidadeInscritos(Guid id)
        {
            var turmasQtdInscritos = _professorService.ConsultarTurmasQuantidadeInscritos(id);

            if (turmasQtdInscritos.Any())
            {
                return Ok(turmasQtdInscritos);
            }

            return NotFound("Não existem turmas cadastradas com a quantidade de inscritos para o professor.");
        }

        [HttpGet]
        public IActionResult ConsultarAvaliacoesDasSuasTurmas(Guid id)
        {
            var avaliacoesTurmas = _professorService.ConsultarAvaliacoesDasSuasTurmas(id);

            if (avaliacoesTurmas.Any())
            {
                return Ok(avaliacoesTurmas);
            }

            return NotFound("Não existem avaliações de quaisquer turmas para o professor.");
        }
    }
}