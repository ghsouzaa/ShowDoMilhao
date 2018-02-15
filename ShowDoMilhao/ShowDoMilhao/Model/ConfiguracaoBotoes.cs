using System;
using System.Collections.Generic;
using System.Text;

namespace ShowDoMilhao.Model
{
    public class ConfiguracaoBotoes
    {
        public bool PulouPergunta { get; set; }
        public bool ConsultouSabios { get; set; }
        public bool UsouCartas { get; set; }

        public ConfiguracaoBotoes()
        {
            PulouPergunta = false;
            ConsultouSabios = false;
            UsouCartas = false;
        }
    }
}
