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
        private List<Model.Nivel> Nivel;
        private List<Model.Pergunta> Perguntas;
        private Model.Pergunta PerguntaSelecionada;
        private Button btnAlternativa;

        public Pergunta(bool NovoJogo = false)
        {
            NavigationPage.SetHasNavigationBar(this, false);

            if (NovoJogo)
            {
                Perguntas = new Model.Pergunta().CarregarPerguntas();
            }

            PerguntaSelecionada = SelecionarUmaPergunta();

            Content = CriarLayout();
        }

        public StackLayout CriarLayout()
        {
            StackLayout stack = new StackLayout();
            stack.HorizontalOptions = LayoutOptions.Center;

            stack.Children.Add(Elements.Elements.imgShowDoMilhaoHeader());

            stack.Children.Add(new Label
            {
                Text = PerguntaSelecionada.Enunciado,
                Margin = new Thickness(Elements.Elements.Margem((float)0.5), 0)
            });

            foreach (var item in PerguntaSelecionada.Alternativas)
            {
                btnAlternativa = new Button();
                btnAlternativa.Text = item.Resposta;
                btnAlternativa.Margin = new Thickness(Elements.Elements.Margem(1), 0);
                btnAlternativa.Clicked += delegate { VoceEstaCerto(item.Correta); };

                stack.Children.Add(btnAlternativa);
            }

            stack.Children.Add(btnVoltar());

            return stack;
        }

        async void VoceEstaCerto(bool sim)
        {
            var resposta = await DisplayAlert("Você está certo disso?", sim.ToString(), "Sim", "Não");
            if (resposta)
            {

            }
        }

        public Model.Pergunta SelecionarUmaPergunta()
        {
            return Perguntas[1];
        }

        public Button btnVoltar()
        {
            Button btn = new Button();
            btn.Text = "Voltar";
            btn.Margin = new Thickness(Elements.Elements.Margem(1), 0);
            btn.VerticalOptions = LayoutOptions.Center;

            btn.Clicked += delegate
            {
                Navigation.PopAsync();
            };

            return btn;
        }
    }
}