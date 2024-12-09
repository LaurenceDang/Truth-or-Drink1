namespace Truth_or_Drink1
{
    public partial class ToolbarItems : ContentPage
    {
	    public ToolbarItems()
	    {
		    InitializeComponent();
	    }

        private void HomeToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void FlyoutToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlyoutPage());
        }
    }
}
