namespace TouchBug;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
    }

    private async void Button_Clicked_1(object sender, EventArgs e) {

        await Shell.Current.DisplayAlert("", "I was suppose to change colors when you hover", "OK");
    }
}
