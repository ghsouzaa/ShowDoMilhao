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
	public partial class Sobre : ContentPage
	{
		public Sobre ()
		{
            NavigationPage.SetHasNavigationBar(this, false);

            StackLayout stack = new StackLayout();
            stack.HorizontalOptions = LayoutOptions.Center;

            stack.Children.Add(Elements.Elements.imgShowDoMilhaoHeader());
            stack.Children.Add(lblMensagemSobre());
            stack.Children.Add(btnVoltar());

            Content = stack;
        }

        public Label lblMensagemSobre()
        {
            return new Label()
            {
                Text = "ESTE JOGO FOI DESENVOLVIDO A PARTIR DE UMA ATIVIDADE DA DISCIPLINA DE COMPUTAÇÃO MÓVEL DO CURSO DE SISTEMAS DE INFORMAÇÃO DA UFMT. SUA UTILIZAÇÃO TEM INTUITO ÚNICO E EXCLUSIVAMENTE ACADÊMICO.",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(Elements.Elements.Margem(1), 0)
            };
        }

        public Button btnVoltar()
        {
            Button btn = new Button();
            btn.Text = "Voltar";
            btn.Margin = new Thickness(Elements.Elements.Margem(1), 0);
            btn.VerticalOptions = LayoutOptions.Center;

            btn.Clicked += delegate {
                Navigation.PopAsync();
            };

            return btn;
        }
    }
}