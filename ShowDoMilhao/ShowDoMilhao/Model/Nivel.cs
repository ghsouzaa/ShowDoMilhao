using System;
using System.Collections.Generic;
using System.Text;

namespace ShowDoMilhao.Model
{
    public class Nivel
    {
        public short Level { get; set; }
        public string Valor { get; set; }
        public string ValorErrar { get; set; }

        public List<Nivel> CarregarNiveis()
        {
            short lvl = 1;
            List<Nivel> list = new List<Nivel>();

            list.Add(new Nivel() { Level = lvl, Valor = "R$ 1.000", ValorErrar = "R$ 0" });
            list.Add(new Nivel() { Level = lvl++, Valor = "R$ 2.000", ValorErrar = "R$ 500" });
            list.Add(new Nivel() { Level = lvl++, Valor = "R$ 3.000", ValorErrar = "R$ 1.000" });
            list.Add(new Nivel() { Level = lvl++, Valor = "R$ 4.000", ValorErrar = "R$ 1.500" });

            return list;
        }
    }
}
