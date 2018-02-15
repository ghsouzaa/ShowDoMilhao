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
	public partial class TelaFim : ContentPage
	{
		public TelaFim (string mensagem)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();

            lblValor.Text = mensagem;
            lblValor.HorizontalOptions = LayoutOptions.Center;
            lblValor.TextColor = new Color(255, 255, 255);
            lblValor.FontSize = 16;
            lblValor.Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0);

            btnNovamente.Clicked += delegate
            {
                var paginas = Navigation.NavigationStack;
                var qtdPages = Navigation.NavigationStack.Count;

                for (var i = qtdPages - 1; i > 0; i--)
                    Navigation.RemovePage(paginas[i]);

                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                Navigation.PushAsync(new Pergunta(new Model.Pergunta().CarregarPerguntas(), new Model.ConfiguracaoBotoes(), true));
            };
            btnNovamente.Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0);

            btnVoltar.Clicked += delegate
            {
                Navigation.PopToRootAsync();
            };
            btnVoltar.Margin = new Thickness(Elements.Elements.Margem((float)0.4), 0);
        }
    }
}