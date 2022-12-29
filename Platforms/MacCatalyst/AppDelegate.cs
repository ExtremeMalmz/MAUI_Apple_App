using Foundation;
using ID_App;

namespace iphone6moai;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	//this dont work solution: Just write mauiprogram till it find it
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
