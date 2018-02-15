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
        private int NivelAtual;
        private List<Model.Nivel> ListaNiveis = new Model.Nivel().CarregarNiveis();
        private List<Model.Pergunta> Perguntas;
        private Model.Pergunta PerguntaSelecionada;

        public Pergunta(List<Model.Pergunta> perguntas, bool NovoJogo = false, int nivelAtual = 0)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Perguntas = perguntas;
            if (NovoJogo)
                NivelAtual = 0;
            else
                NivelAtual = nivelAtual + 1;

            SelecionarUmaPergunta();

            Content = CriarLayout();
        }

        public StackLayout CriarLayout()
        {
            StackLayout stack = new StackLayout();
            stack.HorizontalOptions = LayoutOptions.Center;
            stack.Children.Add(Elements.Elements.imgShowDoMilhaoHeader());


            stack.Children.Add(new Label
            {
                ClassId = "lblNivel",
                Text = "Está pergunta vale: " + ListaNiveis[NivelAtual].Valor,
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0)
            });

            stack.Children.Add(new Label
            {
                ClassId = "lblEnunciado",
                Text = PerguntaSelecionada.Enunciado,
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0)
            });

            foreach (var item in PerguntaSelecionada.Alternativas)
            {
                Button btnAlternativa = new Button();
                btnAlternativa.Text = item.Resposta;
                btnAlternativa.Margin = new Thickness(Elements.Elements.Margem(1), 0);
                btnAlternativa.Clicked += delegate { VoceEstaCerto(item.Correta); };

                stack.Children.Add(btnAlternativa);
            }

            stack.Children.Add(new Label()
            {
                ClassId = "lblAjuda",
                Text = "Ajudas",
                Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0),
                HorizontalOptions = LayoutOptions.CenterAndExpand
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

        async void VoceEstaCerto(bool respostaCerta)
        {
            var resposta = await DisplayAlert("Você está certo disso?", "", "Sim", "Não");
            if (resposta)
            {
                if (respostaCerta)
                {
                    if (NivelAtual != 3)
                        ProximaPergunta();
                    else
                        TelaFim("Parabéns, você conseguiu R$ 1.000.000 em barras de ouro!");
                }
                else
                    TelaFim("Resposta errada. Você conseguiu " + ListaNiveis[NivelAtual].ValorErrar + ".");
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
            Navigation.PushAsync(new Pergunta(Perguntas, false, NivelAtual));
        }

        public void TelaFim(string mensagem)
        {
            Navigation.PushAsync(new TelaFim(mensagem));
        }

        public Button btnDesistir()
        {
            Button btn = new Button();
            btn.Text = "Desistir";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;
            btn.BackgroundColor = new Color(180, 0, 0);
            btn.TextColor = new Color(255, 255, 255);

            btn.Clicked += delegate
            {
                Navigation.PopToRootAsync();
            };

            return btn;
        }

        public Button btnPular()
        {
            Button btn = new Button();
            btn.Text = "Pular";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate
            {
                Navigation.PopToRootAsync();
            };

            return btn;
        }

        public Button btnSabios()
        {
            Button btn = new Button();
            btn.Text = "Sábios";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate
            {
                Navigation.PopToRootAsync();
            };

            return btn;
        }

        public Button btnCartas()
        {
            Button btn = new Button();
            btn.Text = "Cartas";
            btn.VerticalOptions = LayoutOptions.Center;
            btn.HorizontalOptions = LayoutOptions.CenterAndExpand;

            btn.Clicked += delegate
            {
                Navigation.PopToRootAsync();
            };

            return btn;
        }
    }
}