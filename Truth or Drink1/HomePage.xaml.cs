using Microsoft.Maui.Controls;

namespace Truth_or_Drink1
{
    public partial class HomePage : ContentPage
    {  

        public HomePage()
        {
            InitializeComponent();
        }

        private async void HostGameButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new HostGame()); 
        }   
        private async void JoinGameButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new JoinGame()); 
        }
        private async void QRCodeButton_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new QRCode());
        }
    } 
}