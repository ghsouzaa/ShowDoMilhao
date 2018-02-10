using System;
using System.Collections.Generic;
using System.Text;

namespace ShowDoMilhao.Model
{
    public class Pergunta
    {
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Pergunta()
        {
            Alternativas = new List<Alternativa>();
        }

        public Pergunta(string enunciado)
        {
            Enunciado = enunciado;
            Alternativas = new List<Alternativa>();
        }

        public void AddAlternativa(Alternativa a)
        {
            if (Alternativas == null)
                Alternativas = new List<Alternativa>();

            Alternativas.Add(a);
        }

        public List<Pergunta> CarregarPerguntas()
        {
            List<Pergunta> lista = new List<Pergunta>();

            Pergunta p1 = new Pergunta("Sobre a linguagem SQL, a instrução que permite filtrar o resultado de um agrupamento é:");
            p1.AddAlternativa(new Alternativa("HAVING", true));
            p1.AddAlternativa(new Alternativa("WHERE"));
            p1.AddAlternativa(new Alternativa("WHEN"));
            p1.AddAlternativa(new Alternativa("JOIN"));
            lista.Add(p1);

            Pergunta p2 = new Pergunta("Sobre operadores de comparação em JavaScript, qual das alternativas tera o retorno como TRUE para uma variável x = 11?");
            p2.AddAlternativa(new Alternativa("x == “11”", true));
            p2.AddAlternativa(new Alternativa("x ===“11”"));
            p2.AddAlternativa(new Alternativa("x = 11"));
            p2.AddAlternativa(new Alternativa("x = “11”"));
            lista.Add(p2);

            Pergunta p3 = new Pergunta("Qual das alternativas apresentam apenas barramentos de entrada e saída?");
            p3.AddAlternativa(new Alternativa("PCI e MINI-DIN"));
            p3.AddAlternativa(new Alternativa("DB9 e MINI-DIN", true));
            p3.AddAlternativa(new Alternativa("DB9 e ISA"));
            p3.AddAlternativa(new Alternativa("ISA e PCI"));
            lista.Add(p3);

            return lista;
        }
    }
}
