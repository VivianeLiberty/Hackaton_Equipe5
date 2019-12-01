using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Liberty.DesafioOferta.API.Models
{
    public class PropostaVidaRequest
    {
        public long CPF { get; set; }

        public string Nome { get; set; }

        public int CEP { get; set; }

        public string NumeroComplemento { get; set; }

        public decimal ValorContratacao { get; set; }

        public decimal Renda { get; set; }

        public string Profissao { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public bool PossuiConjuge { get; set; }

        public bool PossuiDoencas { get; set; }

        public bool PossuiAvos { get; set; }

        public bool PossuiPlanoSaude { get; set; }

        public bool PraticaExercicio { get; set; }

        public bool Fuma { get; set; }

        public bool Bebe { get; set; }

        public bool PaiMaeFalecimento { get; set; }
    }
}