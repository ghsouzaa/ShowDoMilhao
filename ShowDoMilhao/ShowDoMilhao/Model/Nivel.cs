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
        public string ValorParar { get; set; }
        
        public List<Nivel> CarregarNiveis()
        {
            short lvl = 1;
            List<Nivel> list = new List<Nivel>();

            list.Add(new Nivel() { Level = lvl, ValorParar = "R$ 0", Valor = "R$ 1.000", ValorErrar = "R$ 0" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 1.000", Valor = "R$ 2.000", ValorErrar = "R$ 500" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 2.000", Valor = "R$ 3.000", ValorErrar = "R$ 1.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 3.000", Valor = "R$ 4.000", ValorErrar = "R$ 1.500" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 4.000", Valor = "R$ 5.000", ValorErrar = "R$ 2.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 5.000", Valor = "R$ 10.000", ValorErrar = "R$ 2.500" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 10.000", Valor = "R$ 20.000", ValorErrar = "R$ 5.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 20.000", Valor = "R$ 30.000", ValorErrar = "R$ 10.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 30.000", Valor = "R$ 40.000", ValorErrar = "R$ 15.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 40.000", Valor = "R$ 50.000", ValorErrar = "R$ 20.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 50.000", Valor = "R$ 100.000", ValorErrar = "R$ 25.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 100.000", Valor = "R$ 200.000", ValorErrar = "R$ 50.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 200.000", Valor = "R$ 300.000", ValorErrar = "R$ 100.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 300.000", Valor = "R$ 400.000", ValorErrar = "R$ 150.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 400.000", Valor = "R$ 500.000", ValorErrar = "R$ 200.000" });
            list.Add(new Nivel() { Level = lvl++, ValorParar = "R$ 500.000", Valor = "R$ 1.000.000", ValorErrar = "R$ 0" });

            return list;
        }
    }
}
