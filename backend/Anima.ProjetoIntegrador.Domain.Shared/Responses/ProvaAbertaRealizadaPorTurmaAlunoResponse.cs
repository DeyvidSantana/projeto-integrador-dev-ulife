﻿namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class ProvaAbertaRealizadaPorTurmaAlunoResponse : BaseResponse
    {
        public string? NomeProva { get; set; }
        public double? Nota { get; set; }
        public bool Realizada { get; set; }
    }
}
