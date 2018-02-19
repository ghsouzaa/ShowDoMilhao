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

            Pergunta p3 = new Pergunta("São métodos de implementação de memória virtual:");
            p3.AddAlternativa(new Alternativa("Paginação e escalonamento"));
            p3.AddAlternativa(new Alternativa("Escalonamento e desfragmentação"));
            p3.AddAlternativa(new Alternativa("Segmentação e paginação", true));
            p3.AddAlternativa(new Alternativa("Segmentação e desfragmentação"));
            lista.Add(p3);

            Pergunta p4 = new Pergunta("Nos sistemas operacionais Linux, qual comando NÃO é um gerenciador de pacotes?");
            p4.AddAlternativa(new Alternativa("yum"));
            p4.AddAlternativa(new Alternativa("vi", true));
            p4.AddAlternativa(new Alternativa("apt-get"));
            p4.AddAlternativa(new Alternativa("aptitude"));
            lista.Add(p4);

            Pergunta p5 = new Pergunta("Qual das alternativas apresentam apenas barramentos de entrada e saída?");
            p5.AddAlternativa(new Alternativa("PCI e MINI-DIN"));
            p5.AddAlternativa(new Alternativa("DB9 e MINI-DIN", true));
            p5.AddAlternativa(new Alternativa("DB9 e ISA"));
            p5.AddAlternativa(new Alternativa("ISA e PCI"));
            lista.Add(p5);

            Pergunta p6 = new Pergunta("Qual das alternativas NÃO é um sistema de arquivos utilizado por sistemas operacionais da família Windows?");
            p6.AddAlternativa(new Alternativa("FAT32"));
            p6.AddAlternativa(new Alternativa("FAT16"));
            p6.AddAlternativa(new Alternativa("WFS32", true));
            p6.AddAlternativa(new Alternativa("NTFS"));
            lista.Add(p6);

            Pergunta p7 = new Pergunta("São exemplos de protocolos da camada de aplicação do modelo TCP/IP:");
            p7.AddAlternativa(new Alternativa("TCP e DHCP"));
            p7.AddAlternativa(new Alternativa("FTP e SMTP", true));
            p7.AddAlternativa(new Alternativa("TELNET e IP"));
            p7.AddAlternativa(new Alternativa("SSH e UDP"));
            lista.Add(p7);

            Pergunta p8 = new Pergunta("Qual estrutura de dados se caracteriza por ser lista não linear?");
            p8.AddAlternativa(new Alternativa("Árvores", true));
            p8.AddAlternativa(new Alternativa("Pilhas"));
            p8.AddAlternativa(new Alternativa("Filas"));
            p8.AddAlternativa(new Alternativa("Listas circulares"));
            lista.Add(p8);

            Pergunta p9 = new Pergunta("O modelo ou paradigma de processo de software que intercala as atividades de especificação, desenvolvimento e validação é o modelo");
            p9.AddAlternativa(new Alternativa("cascata"));
            p9.AddAlternativa(new Alternativa("comportamental"));
            p9.AddAlternativa(new Alternativa("evolucionário", true));
            p9.AddAlternativa(new Alternativa("estrutural"));
            lista.Add(p9);

            Pergunta p10 = new Pergunta("NÃO constitui parte do projeto de banco de dados relacional:");
            p10.AddAlternativa(new Alternativa("Conceitual"));
            p10.AddAlternativa(new Alternativa("Lógica"));
            p10.AddAlternativa(new Alternativa("Física"));
            p10.AddAlternativa(new Alternativa("Virtual", true));
            lista.Add(p10);

            Pergunta p11 = new Pergunta("Para ser disparada, toda trigger precisa de um evento associado a ela. Em qual evento uma trigger NÃO pode ser disparada.");
            p11.AddAlternativa(new Alternativa("INSERT"));
            p11.AddAlternativa(new Alternativa("DROP", true));
            p11.AddAlternativa(new Alternativa("UPDATE"));
            p11.AddAlternativa(new Alternativa("DELETE"));
            lista.Add(p11);

            Pergunta p12 = new Pergunta("NÃO é método de busca de dados:");
            p12.AddAlternativa(new Alternativa("Método da bolha", true));
            p12.AddAlternativa(new Alternativa("Método sequencial"));
            p12.AddAlternativa(new Alternativa("Método da busca binária"));
            p12.AddAlternativa(new Alternativa("Método por interpolação"));
            lista.Add(p12);

            Pergunta p13 = new Pergunta("A linguagem SQL definida pela ISO (International Standard Organization) é classificada como");
            p13.AddAlternativa(new Alternativa("declarativa", true));
            p13.AddAlternativa(new Alternativa("procedural"));
            p13.AddAlternativa(new Alternativa("imperativa"));
            p13.AddAlternativa(new Alternativa("funcional"));
            lista.Add(p13);

            Pergunta p14 = new Pergunta("Uma combinação de hardware e software que isola a Internet da rede interna de uma organização, permitindo que alguns pacotes passem e bloqueando outros, é denominada");
            p14.AddAlternativa(new Alternativa("key distribution center"));
            p14.AddAlternativa(new Alternativa("serviço de autenticação"));
            p14.AddAlternativa(new Alternativa("firewall", true));
            p14.AddAlternativa(new Alternativa("autoridade certificadora"));
            lista.Add(p14);

            Pergunta p15 = new Pergunta("O Diagrama de Entidade-Relacionamento (DER) integra a seguinte parte do projeto de banco de dados relacional: ");
            p15.AddAlternativa(new Alternativa("Conceitual", true));
            p15.AddAlternativa(new Alternativa("Virtual"));
            p15.AddAlternativa(new Alternativa("Lógica"));
            p15.AddAlternativa(new Alternativa("Física"));
            lista.Add(p15);

            Pergunta p16 = new Pergunta("A respeito de sistemas de memórias, a memória de acesso aleatório (RAM) estática é utilizada na construção de");
            p16.AddAlternativa(new Alternativa("pendrives"));
            p16.AddAlternativa(new Alternativa("EEPROM"));
            p16.AddAlternativa(new Alternativa("mídias ópticas"));
            p16.AddAlternativa(new Alternativa("memória cache", true));
            lista.Add(p16);

            Pergunta p17 = new Pergunta("Considerando o endereçamento IPv4, qual sistema deve ser utilizado para agrupar um bloco de endereços de modo a diminuir as tabelas de roteamento?");
            p17.AddAlternativa(new Alternativa("NAT"));
            p17.AddAlternativa(new Alternativa("Fragment Offset"));
            p17.AddAlternativa(new Alternativa("VLSI"));
            p17.AddAlternativa(new Alternativa("CIDR", true));
            lista.Add(p17);

            Pergunta p18 = new Pergunta("Em redes wireless, em um ambiente contendo múltiplos access points dentro de uma WLAN, o identificador utilizado para reconhecer as associações entre estes access points e seus clientes é:");
            p18.AddAlternativa(new Alternativa("SSID"));
            p18.AddAlternativa(new Alternativa("IP"));
            p18.AddAlternativa(new Alternativa("Domínio"));
            p18.AddAlternativa(new Alternativa("BSSID", true));
            lista.Add(p18);






            return lista;
        }
    }
}
