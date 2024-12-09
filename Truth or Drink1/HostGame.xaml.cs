namespace Truth_or_Drink1;

public partial class HostGame : ContentPage
{
	public HostGame()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new HomePage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
       
    }
}