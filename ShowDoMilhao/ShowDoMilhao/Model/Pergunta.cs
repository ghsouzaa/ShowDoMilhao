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

            Pergunta p19 = new Pergunta("O Terminal Server é um serviço que possibilita o acesso remoto a estações e servidores.Levando em consideração o acesso remoto, qual protocolo é utilizado para a comunicação entre o Terminal Server e o cliente do Terminal Server?");
            p19.AddAlternativa(new Alternativa("RDU"));
            p19.AddAlternativa(new Alternativa("RDD"));
            p19.AddAlternativa(new Alternativa("DPR"));
            p19.AddAlternativa(new Alternativa("RDP", true));
            lista.Add(p19);

            Pergunta p20 = new Pergunta("É uma das principais peças do computador, onde todos os seus periféricos são acoplados.Possui um conjunto de slots, tais como: ISA, AGP, PCI, PCI Express etc: ");
            p20.AddAlternativa(new Alternativa("Placa de vídeo"));
            p20.AddAlternativa(new Alternativa("Placa mãe", true));
            p20.AddAlternativa(new Alternativa("Placa de rede"));
            p20.AddAlternativa(new Alternativa("Processador"));
            lista.Add(p20);

            Pergunta p21 = new Pergunta("Qual o comando utilizado para abrir uma nova guia no navegador Google Chrome ? ");
            p21.AddAlternativa(new Alternativa("Ctrl+F"));
            p21.AddAlternativa(new Alternativa("Ctrl+T", true));
            p21.AddAlternativa(new Alternativa("Ctrl+P"));
            p21.AddAlternativa(new Alternativa("Ctrl+N"));
            lista.Add(p21);

            Pergunta p22 = new Pergunta("É um dos principais softwares aplicativos dos sistemas operacionais e utilizado para acessar a Internet, a exemplo de Internet Explorer, Chrome, Safari e Mozilla Firefox: ");
            p22.AddAlternativa(new Alternativa("Editor de textos"));
            p22.AddAlternativa(new Alternativa("Planilha eletrônica"));
            p22.AddAlternativa(new Alternativa("Navegador de internet", true));
            p22.AddAlternativa(new Alternativa("Correio eletrônico"));
            lista.Add(p22);

            Pergunta p23 = new Pergunta("Qual padrão de comunicação de redes sem fio tem por objetivo substituir cabos, permitindo que celulares, palmtops, mouses, entre outros, troquem dados entre si e com o microcomputador sem precisar de cabos ? ");
            p23.AddAlternativa(new Alternativa("Bluetooth", true));
            p23.AddAlternativa(new Alternativa("Infravermelho"));
            p23.AddAlternativa(new Alternativa("Wi-Fi"));
            p23.AddAlternativa(new Alternativa("Wimax"));
            lista.Add(p23);

            Pergunta p24 = new Pergunta("O controle de diálogo, o gerenciamento de token e a sincronização são características de qual camada do Modelo OSI/ ISO?");
            p24.AddAlternativa(new Alternativa("Sessão", true));
            p24.AddAlternativa(new Alternativa("Transporte"));
            p24.AddAlternativa(new Alternativa("Enlace de Dados"));
            p24.AddAlternativa(new Alternativa("Apresentação"));
            lista.Add(p24);

            Pergunta p25 = new Pergunta("Em uma arquitetura de rede sem fio 802.11, qual processo ocorre após a varredura e decisão de conexão a um dos AP disponíveis?");
            p25.AddAlternativa(new Alternativa("Autenticação"));
            p25.AddAlternativa(new Alternativa("Sinalização"));
            p25.AddAlternativa(new Alternativa("Associação", true));
            p25.AddAlternativa(new Alternativa("Autorização"));
            lista.Add(p25);

            Pergunta p26 = new Pergunta("Em relação à segurança da informação, pode-se afirmar que o algoritmo RSA implementa a criptografia e a decriptação de mensagens, utilizando:");
            p26.AddAlternativa(new Alternativa("chaves simétricas"));
            p26.AddAlternativa(new Alternativa("chaves simétricas polialfabéticas"));
            p26.AddAlternativa(new Alternativa("somente chave privada"));
            p26.AddAlternativa(new Alternativa("chave pública e privada", true));
            lista.Add(p26);

            Pergunta p27 = new Pergunta("É considerada uma atividade inicial de teste de sistemas que verifica se os componentes funcionam em conjunto, com objetivo de detectar defeitos no sistema.Essa atividade corresponde ao Teste");
            p27.AddAlternativa(new Alternativa("de integração", true));
            p27.AddAlternativa(new Alternativa("de releases ou caixa-preta"));
            p27.AddAlternativa(new Alternativa("estrutural"));
            p27.AddAlternativa(new Alternativa("de componentes"));
            lista.Add(p27);

            Pergunta p28 = new Pergunta("A linguagem Java utiliza-se de bytecode e da JVM para conseguir a seguinte característica:");
            p28.AddAlternativa(new Alternativa("Portabilidade", true));
            p28.AddAlternativa(new Alternativa("Emulação"));
            p28.AddAlternativa(new Alternativa("Internacionalização"));
            p28.AddAlternativa(new Alternativa("Interpretação"));
            lista.Add(p28);

            Pergunta p29 = new Pergunta("O tipo de ataque a sistemas computacionais que consiste em criar um registro falso de um endereço IP em um servidor de nomes é denominado:");
            p29.AddAlternativa(new Alternativa("DDOS"));
            p29.AddAlternativa(new Alternativa("Man-in- the-middle"));
            p29.AddAlternativa(new Alternativa("Session hijacking"));
            p29.AddAlternativa(new Alternativa("DNS Spoofing", true));
            lista.Add(p29);

            Pergunta p30 = new Pergunta("Considerando o endereçamento IPv4, quantos hosts são designados em uma subrede de máscara 255.255.255.224?");
            p30.AddAlternativa(new Alternativa("30", true));
            p30.AddAlternativa(new Alternativa("62"));
            p30.AddAlternativa(new Alternativa("126"));
            p30.AddAlternativa(new Alternativa("60"));
            lista.Add(p30);

            Pergunta p31 = new Pergunta("Qual das alternativa que apresenta o padrão mais indicado para obter uma maior segurança em redes 802.11?");
            p31.AddAlternativa(new Alternativa("WPA"));
            p31.AddAlternativa(new Alternativa("TKIP"));
            p31.AddAlternativa(new Alternativa("WPA2", true));
            p31.AddAlternativa(new Alternativa("WEP"));
            lista.Add(p31);

            Pergunta p32 = new Pergunta("Qual dos seguintes protocolos de segurança de redes 802.11 utiliza o algoritmo de criptografía simétrica AES com chave de 128 bits?");
            p32.AddAlternativa(new Alternativa("RC4"));
            p32.AddAlternativa(new Alternativa("WEP"));
            p32.AddAlternativa(new Alternativa("RSA"));
            p32.AddAlternativa(new Alternativa("WPA2", true));
            lista.Add(p32);

            Pergunta p33 = new Pergunta("Quais são os dois modos de operação de rede sem fio(802.11)?");
            p33.AddAlternativa(new Alternativa("RTS e CTS"));
            p33.AddAlternativa(new Alternativa("Infraestrutura e Ad hoc", true));
            p33.AddAlternativa(new Alternativa("ESS e BSS"));
            p33.AddAlternativa(new Alternativa("CSMA/CA e CSMA/CD"));
            lista.Add(p33);

            Pergunta p34 = new Pergunta("Qual é a nomenclatura adotada que define um conjunto de dispositivos formado pela união de vários BSSs conectados por um sistema de distribuição?");
            p34.AddAlternativa(new Alternativa("ESS", true));
            p34.AddAlternativa(new Alternativa("BSSID"));
            p34.AddAlternativa(new Alternativa("ESSID"));
            p34.AddAlternativa(new Alternativa("SSID"));
            lista.Add(p34);

            Pergunta p35 = new Pergunta("Qual o significado da sigla P2P?");
            p35.AddAlternativa(new Alternativa("PHP"));
            p35.AddAlternativa(new Alternativa("Peer-to-peer", true));
            p35.AddAlternativa(new Alternativa("PowerPoint"));
            p35.AddAlternativa(new Alternativa("Ponto de Acesso"));
            lista.Add(p35);

            Pergunta p36 = new Pergunta("Quando um navegador de Internet comunica com servidores Web, através do endereço www, o pedido dos arquivos web é efetuado por qual protocolo(s)?");
            p36.AddAlternativa(new Alternativa("IMAP"));
            p36.AddAlternativa(new Alternativa("SMTP e FTP"));
            p36.AddAlternativa(new Alternativa("HTTP", true));
            p36.AddAlternativa(new Alternativa("IRC"));
            lista.Add(p36);

            Pergunta p37 = new Pergunta("Qual dispositivo serve como filtro de pacotes, regulando o tráfego de dados que entram e saem da rede?");
            p37.AddAlternativa(new Alternativa("IDS"));
            p37.AddAlternativa(new Alternativa("IPS"));
            p37.AddAlternativa(new Alternativa("FIREWALL", true));
            p37.AddAlternativa(new Alternativa("ANTIVÍRUS"));
            lista.Add(p37);

            Pergunta p38 = new Pergunta("Quais teclas são utilizadas como atalho para selecionar tudo no Word?");
            p38.AddAlternativa(new Alternativa("CTRL+T", true));
            p38.AddAlternativa(new Alternativa("CTRL+L"));
            p38.AddAlternativa(new Alternativa("CTRL+X"));
            p38.AddAlternativa(new Alternativa("CTRL+C"));
            lista.Add(p38);

            Pergunta p39 = new Pergunta("Qual o comando utilizado no Linux para listar o diretório corrente?");
            p39.AddAlternativa(new Alternativa("RM"));
            p39.AddAlternativa(new Alternativa("MKDIR", true));
            p39.AddAlternativa(new Alternativa("SHUTDOWN -R"));
            p39.AddAlternativa(new Alternativa("LS"));
            lista.Add(p39);

            Pergunta p40 = new Pergunta("Diversos modelos de barramento tais como ISA e PCI, por exemplo, são, disponibilizados na placa mãe dos microcomputadores por meio de conectores chamados de?");
            p40.AddAlternativa(new Alternativa("BIOS"));
            p40.AddAlternativa(new Alternativa("USB"));
            p40.AddAlternativa(new Alternativa("SLOTS", true));
            p40.AddAlternativa(new Alternativa("CMOS"));
            lista.Add(p40);

            Pergunta p41 = new Pergunta("Qual equipamento que permite efetuar comunicação de dados por intermédio de uma linha telefônica?");
            p41.AddAlternativa(new Alternativa("CD-ROM"));
            p41.AddAlternativa(new Alternativa("CPU"));
            p41.AddAlternativa(new Alternativa("HardDisk"));
            p41.AddAlternativa(new Alternativa("MODEM", true));
            lista.Add(p41);

            Pergunta p42 = new Pergunta("Como é chamado o núcleo de um sistema operacional?");
            p42.AddAlternativa(new Alternativa("SHELL"));
            p42.AddAlternativa(new Alternativa("KERNEL", true));
            p42.AddAlternativa(new Alternativa("TELNET"));
            p42.AddAlternativa(new Alternativa("DOS"));
            lista.Add(p42);

            Pergunta p43 = new Pergunta("Quais são os principais protocolos da camada de Transporte?");
            p43.AddAlternativa(new Alternativa("IP E TCP"));
            p43.AddAlternativa(new Alternativa("TCP E UDP", true));
            p43.AddAlternativa(new Alternativa("HTTP E SMTP"));
            p43.AddAlternativa(new Alternativa("HTTP E SMTP"));
            lista.Add(p43);

            Pergunta p44 = new Pergunta("Em quantas camadas se divide o modelo de referência OSI?");
            p44.AddAlternativa(new Alternativa("4"));
            p44.AddAlternativa(new Alternativa("5"));
            p44.AddAlternativa(new Alternativa("6"));
            p44.AddAlternativa(new Alternativa("7", true));
            lista.Add(p44);

            Pergunta p45 = new Pergunta("Steve Jobs fundou a Apple junto com:");
            p45.AddAlternativa(new Alternativa("Lary Page"));
            p45.AddAlternativa(new Alternativa("Bill Gates"));
            p45.AddAlternativa(new Alternativa("Steve Wozniack", true));
            p45.AddAlternativa(new Alternativa("Mark Zuckerberg"));
            lista.Add(p45);

            Pergunta p46 = new Pergunta("São extensões usadas em formatos de video?");
            p46.AddAlternativa(new Alternativa(".RMVB/.AVI/.MOV", true));
            p46.AddAlternativa(new Alternativa(".MP3/.WMA/.WAVE"));
            p46.AddAlternativa(new Alternativa(".AVI/.MPG/.JPG"));
            p46.AddAlternativa(new Alternativa(".DVD/.EXE/.AVI"));
            lista.Add(p46);

            Pergunta p47 = new Pergunta("Qual dessas formas de armazenamento é considerada volátil?");
            p47.AddAlternativa(new Alternativa("HD"));
            p47.AddAlternativa(new Alternativa("SSD"));
            p47.AddAlternativa(new Alternativa("CD"));
            p47.AddAlternativa(new Alternativa("RAM", true));
            lista.Add(p47);

            Pergunta p48 = new Pergunta("Qual das seguintes variáveis só aceita números inteiros?");
            p48.AddAlternativa(new Alternativa("String"));
            p48.AddAlternativa(new Alternativa("Long"));
            p48.AddAlternativa(new Alternativa("Integer", true));
            p48.AddAlternativa(new Alternativa("Double"));
            lista.Add(p48);

            Pergunta p49 = new Pergunta("Protocolo responsável por identificar endereçamento ip através de domínios?");
            p49.AddAlternativa(new Alternativa("DNS", true));
            p49.AddAlternativa(new Alternativa("OSI"));
            p49.AddAlternativa(new Alternativa("FTP"));
            p49.AddAlternativa(new Alternativa("VPN"));
            lista.Add(p49);

            Pergunta p50 = new Pergunta("O Byte é formado por quantos bits?");
            p50.AddAlternativa(new Alternativa("2"));
            p50.AddAlternativa(new Alternativa("4"));
            p50.AddAlternativa(new Alternativa("6"));
            p50.AddAlternativa(new Alternativa("8", true));
            lista.Add(p50);

            return lista;
        }
    }
}
