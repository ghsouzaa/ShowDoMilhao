using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShowDoMilhao.Elements
{
    public static class Elements
    {
        public static Image imgShowDoMilhaoHeader()
        {
            return new Image
            {
                Source = "milhaoHeader.jpg",
                VerticalOptions = LayoutOptions.Start
            };
        }

        public static Image imgShowDoMilhao()
        {
            return new Image
            {
                Source = "milhao.jpg",
                VerticalOptions = LayoutOptions.Start
            };
        }

        public static Image backMilhao()
        {
            return new Image
            {
                Source = "back.jpg",
                VerticalOptions = LayoutOptions.Start,
                Aspect = Aspect.AspectFill
            };
        }

        #region Métodos

        public static double Margem(float percent)
        {
            return ((Application.Current.MainPage.Width * percent) / 2) / 2;
        }

        #endregion
    }
}
