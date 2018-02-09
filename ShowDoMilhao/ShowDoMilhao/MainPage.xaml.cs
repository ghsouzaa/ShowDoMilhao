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
		public MainPage()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            btnIniciar.Margin = new Thickness(50, 0);
            btnIniciar.Clicked += delegate {
                Navigation.PushAsync(new Pergunta(true));
            };

            btnSobre.Margin = new Thickness(50, 0);
            btnSobre.Clicked += delegate {
                Navigation.PushAsync(new Sobre());
            };
        }
    }
}
