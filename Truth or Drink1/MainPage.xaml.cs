namespace Truth_or_Drink1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogInButton_Clicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            string Username = UsernameEntry.Text;
            string Password = UsernameEntry.Text;

            
            if (isUsernameEmpty)
            {
                UsernameEntry.Placeholder = "Vul iets in";
            }
            else if (isPasswordEmpty)
            {
                PasswordEntry.Placeholder = "Vul iets in";
            }

            if (Username == null && Password == null)
            {
                
                await Navigation.PushAsync(new HomePage());
            }
            

        
        }

    }
}
