using System.Linq;

using Xamarin.UITest;

using MobileAzureDevDays.Shared.Constants;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace MobileAzureDevDays.UITests
{
	public class LoginPage : BasePage
    {
		readonly Query loginButton;

		public LoginPage(IApp app) : base(app, PageTitles.LoginPage)
		{
			
			loginButton = x => x.Marked(AutomationIdConstants.LoginButton);
           
		}
        
		public void TapLoginButton()
		{
			App.Tap(loginButton);
			//return new SentimentPage(App);
		}

    }
}
