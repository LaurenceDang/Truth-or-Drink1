namespace Truth_or_Drink1;

public partial class QRCode : ContentPage
{
	public QRCode()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new HomePage());
    }
}