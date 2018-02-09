using System;
using System.Collections.Generic;
using System.Text;

namespace ShowDoMilhao.Model
{
    public class Alternativa
    {
        public string Resposta { get; set; }
        public bool Correta { get; set; }

        public Alternativa(string resposta, bool correta = false)
        {
            Resposta = resposta;
            Correta = correta;
        }
    }
}
