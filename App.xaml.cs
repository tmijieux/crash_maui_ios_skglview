namespace test_skia;
using SkiaSharp.Views.Maui.Controls;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ContentPage {
                    Content = new SKGLView()
                };
	}
}
