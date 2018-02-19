using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShowDoMilhao.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cartas : ContentPage
	{
        public int Nivel;
        public List<Model.Pergunta> ListaPerguntas;
        public Model.Pergunta Pergunta;
        public Model.ConfiguracaoBotoes Config;

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public Cartas(int NivelAtual, List<Model.Pergunta> Perguntas, Model.Pergunta PerguntaAtual, Model.ConfiguracaoBotoes ConfigBotoes)
		{
            NavigationPage.SetHasNavigationBar(this, false);

            Nivel = NivelAtual;
            ListaPerguntas = Perguntas;
            Pergunta = PerguntaAtual;
            Config = ConfigBotoes;

            Content = CriarLayout();
		}

        public StackLayout CriarLayout()
        {
            StackLayout stack = new StackLayout();
            stack.BackgroundColor = Color.FromRgb(7, 34, 61);
            stack.Children.Add(Elements.Elements.imgShowDoMilhaoHeader());
            stack.Children.Add(new Label() { Text = "Escolha uma das cartas", HorizontalOptions = LayoutOptions.Center, TextColor = Color.White });

            var grid = new Grid();
            grid.BackgroundColor = Color.FromRgb(7, 34, 61);

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var imagem = Elements.Elements.imgShowDoMilhaoHeader();

            grid.Children.Add(btnCarta(1), 0, 0);
            grid.Children.Add(btnCarta(3), 0, 1);
            grid.Children.Add(btnCarta(2), 1, 0);
            grid.Children.Add(btnCarta(4), 1, 1);

            stack.Children.Add(grid);
            return stack;
        }

        public Image btnCarta(int i)
        {
            var tapinho = new TapGestureRecognizer();
            tapinho.Tapped += (s, e) =>
            {
                SelecionarCarta();
            };

            var img = new Image() { Source = "cartas"+i.ToString()+".png" };
            img.GestureRecognizers.Add(tapinho);
            return img;
        }

        async void SelecionarCarta()
        {
            Random rd = new Random();
            var qtdOpcoes = rd.Next(0, 4);

            var opcoesParaExcluir = Pergunta.Alternativas.Where(x => x.Correta == false).OrderBy(x => x.Resposta).ToList();

            if (qtdOpcoes > 0)
            {
                for (var i = 0; i <= qtdOpcoes - 1; i++)
                {
                    opcoesParaExcluir[i].Disponivel = false;
                }
            }

            Config.UsouCartas = true;

            await DisplayAlert("Você eliminou:", qtdOpcoes.ToString() + " alternativas", "OK");
            await Navigation.PushAsync(new Pergunta(ListaPerguntas, Config, Pergunta, Nivel));
        }
    }
}