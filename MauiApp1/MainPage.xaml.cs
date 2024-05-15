using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private Label TestLabel1 = new() { Text = "Test label 1" };
	private Button TestButton1 = new() { Text = "Test button 1" };
	
	public MainPage()
	{
		InitializeComponent();
		TestButton1.Clicked += OnCounterClicked;
		RootBorder.StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(24,24,0,0) };
		RootBorder.Content = new VerticalStackLayout
		{
			VerticalOptions = LayoutOptions.Center,
			Spacing = 25,
			Children =
			{
				TestLabel1,
				TestButton1
			}
		};
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		TestLabel1.IsVisible = !TestLabel1.IsVisible;
	}
}

