using GenericSamples.ViewModels;

namespace GenericSamples;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        (sender as ListView).SelectedItem = null;

        if (e.SelectedItem != null)
        {
            MainPageViewModel viewModel = e.SelectedItem as MainPageViewModel;
            Page page = (Page)Activator.CreateInstance(viewModel.Type);
            await Navigation.PushAsync(page);
        }
    }
}

