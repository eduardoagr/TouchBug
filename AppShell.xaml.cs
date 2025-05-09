namespace TouchBug;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
    }

    private async Task Button_Clicked(object sender, EventArgs e) {

        await Shell.Current.DisplayAlert("", "BUG", "OK");
    }
}
