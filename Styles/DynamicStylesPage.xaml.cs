namespace Styles;

public partial class DynamicStylesPage : ContentPage
{
	public DynamicStylesPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.Resources.TryGetValue("specialButton", out var retVal);
		Resources["dynamicStyle"] = (Style)retVal; ;
    }
} 