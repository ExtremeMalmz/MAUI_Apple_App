using ID_App.Pages;

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
    /// <summary>
    /// Makes the buttons turn purple and red after clicking
	/// @params (theButton) the button were sending in to be changed into these colors
    /// </summary>
	private static void ChangeButtonColor(Button theButton)
	{
        

        //change border color 
        theButton.BorderColor = Colors.Purple;
        //change text color
        theButton.TextColor = Colors.Red;
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

    /// <summary>
    /// Click the first button and we go to the hypothesis
    /// </summary>
    private void OnButton1Clicked(object sender, EventArgs e)
	{
		ChangeButtonColor(Button1);

		//change the page to hypothesis
		//App.Current.MainPage = new NavigationPage(new Page1());
		Navigation.PushAsync(new Page1());
    }

    /// <summary>
    /// Click the first button and we go to the first semester
    /// </summary>
    private void OnButton2Clicked(object sender, EventArgs e)
    {
        

        ChangeButtonColor(Button2);

        //change the page to semester 1
        Navigation.PushAsync(new Page2());
    }

    /// <summary>
    /// Click the first button and we go to the second semester
    /// </summary>
    private void OnButton3Clicked(object sender, EventArgs e)
	{
       

        ChangeButtonColor(Button3);

        //change the page that is displayed
        Navigation.PushAsync(new Page3());
    }

    /// <summary>
    /// Click the first button and we go to the third semester
    /// </summary>
    private void OnButton4Clicked(object sender, EventArgs e)
    {
        ChangeButtonColor(Button4);

        Navigation.PushAsync(new Page4());
    }

    /// <summary>
    /// Click the first button and we go to the conclusion
    /// </summary>
    private void OnButton5Clicked(object sender, EventArgs e)
    {
        ChangeButtonColor(Button5);

        Navigation.PushAsync(new Page5());
    }
}