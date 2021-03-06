﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Dominio.Entidades
{
    public class RespostaAluno
    {
        public int Id { get; set; }

        [ForeignKey("AlunoProva")]
        public int AlunoProvaId { get; set; }

        public int Pergunta { get; set; }
        public string Resposta { get; set; }

        public virtual AlunoProva AlunoProva { get; set; }
    }
}
