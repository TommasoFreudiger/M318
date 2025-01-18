using AvventuraPokemon.Models;

namespace AvventuraPokemon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Metodo per navigare verso la PokedexPage
        private async void Button_Clicked_Scegli(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PokedexPage());
        }

        // Metodo per navigare verso la AllenaPage
        private async void Button_Clicked_Allena(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllenaPage());
        }

    }

}
