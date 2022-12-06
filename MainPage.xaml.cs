namespace ID_App;

public partial class MainPage : ContentPage
{
	/// <summary>
	/// Handles the interactions between the contentpage and the code
	/// Basically write code here
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

    /*
	private void OnCounterClicked(object sender, EventArgs e)
	{
		int count = 0;
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	*/

    private void OnButton1Clicked(object sender, EventArgs e)
	{
		/// <summary>
		/// Click the first button and we go to the Page1
		/// </summary>

		Button1.Text = "clicked";

        App.Current.MainPage = new NavigationPage(new Page1());

    }
}

