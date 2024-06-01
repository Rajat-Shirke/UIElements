using SkiaSharp.Extended.UI.Controls;

namespace UIPractice;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void gridlayout_Clicked(System.Object sender, System.EventArgs e)
    {
        lottieview.IsVisible =  false;
        loadingview.IsVisible = true;
        
        Task.Delay(5000);

        Navigation.PushAsync(new overlappingLottieinGridLayout());
    }

}


