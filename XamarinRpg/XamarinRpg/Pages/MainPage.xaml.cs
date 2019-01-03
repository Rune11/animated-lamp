using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinRpg
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (App.Current.Properties.ContainsKey("existing")) {
                BtnLoadGame.IsEnabled = true;
            }
        }

        #region Button click event handlers

        private void BtnNewGame_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NewGamePage();
        }

        private void BtnExitGame_Clicked(object sender, EventArgs e)
        {
            App.Current.Quit();
        }

        private void BtnLoadGame_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoadPage();
        }

        #endregion
    }
}
