using System;

using Xamarin.Forms;
using MobileAzureDevDays.Shared.Constants;

namespace MobileAzureDevDays.Pages
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {

			Button button = new Button { 
				Text = "Login", 
                AutomationId = AutomationIdConstants.LoginButton
			};
			button.Clicked += async (sender, e) =>
			{
				throw new Exception("Crashed!");
				await Navigation.PushAsync(new SentimentPage());
			};

			Content = new StackLayout
			{
				Children = {
					button
                }
            };
        }
    }
}

