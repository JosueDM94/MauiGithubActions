using MauiGithubActions.Shared;

namespace MauiGithubActions;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Console.WriteLine(ApiConstants.ApiUrl);
    }
}

