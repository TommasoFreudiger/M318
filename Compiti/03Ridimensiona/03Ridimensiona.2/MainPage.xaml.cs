using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace _03Ridimensiona._2
{
    public partial class MainPage : ContentPage
    {
        int ret_base = 150;
        int ret_larghezza = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ret_larghezza = Convert.ToInt32(entry_dim.Text);

            if (ret_larghezza <= ret_base || ret_larghezza > Window.Width)
            {
                rettangolo.WidthRequest = ret_base;
            }
            else 
            {
                rettangolo.WidthRequest = ret_larghezza;
            }
        }

    }
}