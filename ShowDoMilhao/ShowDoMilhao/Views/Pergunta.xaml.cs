using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShowDoMilhao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pergunta : ContentPage
    {
        private int ultimoNivel = 15;
        private int NivelAtual;
        private List<Model.Nivel> ListaNiveis = new Model.Nivel().CarregarNiveis();
        private List<Model.Pergunta> Perguntas;
        private Model.Pergunta PerguntaSelecionada;
        private Model.ConfiguracaoBotoes ConfiguracaoBotoes;
        private string RespostaCorreta = "";

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public Pergunta(List<Model.Pergunta> perguntas, Model.ConfiguracaoBotoes config, bool NovoJogo = false, int nivelAtual = 0)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Perguntas = perguntas;
            ConfiguracaoBotoes = config;
            if (NovoJogo)
                NivelAtual = 0;
            else
                NivelAtual = nivelAtual + 1;

            SelecionarUmaPergunta();

            Content = CriarLayout();
        }

        public Pergunta(List<Model.Pergunta> perguntas, Model.ConfiguracaoBotoes config, Model.Pergunta jaSelecionada, int nivelAtual = 0)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Perguntas = perguntas;
            ConfiguracaoBotoes = config;
            NivelAtual = nivelAtual;

            PerguntaSelecionada = jaSelecionada;

            Content = CriarLayout();
        }

        public StackLayout CriarLayout()
        {
            StackLayout stack = new StackLayout();
            stack.BackgroundColor = Color.FromRgb(7,34,61);
            stack.HorizontalOptions = LayoutOptions.Center;
            stack.Children.Add(Elements.Elements.imgShowDoMilhaoHeader());

            stack.Children.Add(new ScrollView { Content = LayoutParcial() });

            return stack;
        }

        public StackLayout LayoutParcial()
        {
            StackLayout stack = new StackLayout();

            stack.Children.Add(new Label
            {
                ClassId = "lblNivel",
                Text = "Está pergunta vale: " + ListaNiveis[NivelAtual].Valor,
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0),
                TextColor = Color.White
            });

            stack.Children.Add(new Label
            {
                ClassId = "lblEnunciado",
                Text = PerguntaSelecionada.Enunciado,
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0),
                TextColor = Color.White
            });

            foreach (var item in PerguntaSelecionada.Alternativas)
            {
                Button btnAlternativa = new Button();
                btnAlternativa.Text = item.Resposta;
                btnAlternativa.Margin = new Thickness(Elements.Elements.Margem(1), 0);
                btnAlternativa.Clicked += delegate { VoceEstaCerto(item.Correta); };
                if (!item.Disponivel)
                    btnAlternativa.IsEnabled = false;

                stack.Children.Add(btnAlternativa);
            }

            stack.Children.Add(new Label()
            {
                ClassId = "lblAjuda",
                Text = "Ajudas",
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.White
            });

            stack.Children.Add(
                new StackLayout
                {
                    Spacing = 0,
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        btnCartas(),
                        btnSabios(),
                        btnPular()
                    }
                }
            );

            stack.Children.Add(btnDesistir());
            return stack;
        }

        #region Eventos

        async void VoceEstaCerto(bool respostaCerta)
        {
            var resposta = await DisplayAlert("Você está certo disso?", "", "Sim", "Não");
            if (resposta)
            {
                if (respostaCerta)
                {
                    if (NivelAtual != 15)
                    {
                        await DisplayAlert("Certa a resposta!", "Próximo pergunta valendo " + ListaNiveis[NivelAtual + 1].Valor, "OK");
                        ProximaPergunta();
                    }
                    else
                        TelaFim("Parabéns, você conseguiu R$ 1.000.000 em barras de ouro!");
                }
                else
                    TelaFim("Resposta errada. Você conseguiu " + ListaNiveis[NivelAtual].ValorErrar);
            }
        }

        public void SelecionarUmaPergunta()
        {
            Random random = new Random();
            var num = random.Next(0, (Perguntas.Count() - 1));
            PerguntaSelecionada = Perguntas[num];

            Perguntas.Remove(PerguntaSelecionada);
        }

        public void ProximaPergunta()
        {
            Navigation.PushAsync(new Pergunta(Perguntas, ConfiguracaoBotoes, false, NivelAtual));
        }

        async void PularPergunta()
        {
            var resposta = await DisplayAlert("Realmente deseja pular a pergunta?", "", "Sim", "Não");
            if (resposta)
            {
                ConfiguracaoBotoes.PulouPergunta = true;
                await Navigation.PushAsync(new Pergunta(Perguntas, ConfiguracaoBotoes, false, NivelAtual - 1));
            }
        }

        async void ConsultarSabios()
        {
            if (RespostaCorreta == "")
            {
                var resposta = await DisplayAlert("Realmente deseja consultar os sábios?", "", "Sim", "Não");
                if (resposta)
                {
                    ConfiguracaoBotoes.ConsultouSabios = true;

                    Random rd = new Random();
                    var percent = rd.Next(0, 100);
                    if (percent <= 90)
                        RespostaCorreta = PerguntaSelecionada.Alternativas.FirstOrDefault(x => x.Correta).Resposta;
                    else
                        RespostaCorreta = PerguntaSelecionada.Alternativas.Where(x => x.Correta != true).FirstOrDefault().Resposta;

                    await DisplayAlert("Os sábios responderam:", RespostaCorreta.ToUpper(), "OK");
                }
            }
            else
            {
                await DisplayAlert("Os sábios responderam:", RespostaCorreta.ToUpper(), "OK");
            }
        }

        async void Desistir()
        {
            var resposta = await DisplayAlert("Você receberá " + ListaNiveis[NivelAtual].ValorParar + " se desistir agora. Deseja desistir?", "", "Sim", "Não");
            if (resposta)
            {
                await Navigation.PushAsync(new TelaFim("Você desistiu e faturou " + ListaNiveis[NivelAtual].ValorParar));
            }
        }

        async void Cartas()
        {
            var resposta = await DisplayAlert("Tem certeza que deseja usar as cartas?", "", "Sim", "Não");
            if (resposta)
            {
                await Navigation.PushAsync(new Cartas(NivelAtual, Perguntas, PerguntaSelecionada, ConfiguracaoBotoes));
            }
        }

        public void TelaFim(string mensagem)
        {
            Navigation.PushAsync(new TelaFim(mensagem));
        }

        #endregion

        #region Botões

        public Button btnDesistir()
        {
            Button btn = new Button();
            btn.Text = "Desistir";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;
            btn.BackgroundColor = new Color(180, 0, 0);
            btn.TextColor = new Color(255, 255, 255);

            btn.Clicked += delegate { Desistir(); };

            return btn;
        }

        public Button btnPular()
        {
            Button btn = new Button();
            btn.Text = "Pular";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate { PularPergunta(); };

            if (ConfiguracaoBotoes.PulouPergunta || NivelAtual == ultimoNivel)
                btn.IsEnabled = false;

            return btn;
        }

        public Button btnSabios()
        {
            Button btn = new Button();
            btn.Text = "Sábios";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate { ConsultarSabios(); };

            if (ConfiguracaoBotoes.ConsultouSabios || NivelAtual == ultimoNivel)
                btn.IsEnabled = false;

            return btn;
        }

        public Button btnCartas()
        {
            Button btn = new Button();
            btn.Text = "Cartas";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate { Cartas(); };

            if (ConfiguracaoBotoes.UsouCartas || NivelAtual == ultimoNivel)
                btn.IsEnabled = false;

            return btn;
        }

        #endregion
    }
}