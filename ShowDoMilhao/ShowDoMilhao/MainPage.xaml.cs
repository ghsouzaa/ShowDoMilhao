﻿using ShowDoMilhao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShowDoMilhao
{
	public partial class MainPage : ContentPage
	{
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public MainPage()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            btnIniciar.Margin = new Thickness(50, 0);
            btnIniciar.Clicked += delegate {
                Navigation.PushAsync(new Pergunta(new Model.Pergunta().CarregarPerguntas(), new Model.ConfiguracaoBotoes(), true));
            };

            btnSobre.Margin = new Thickness(50, 0);
            btnSobre.Clicked += delegate {
                Navigation.PushAsync(new Sobre());
            };
        }
    }
}
