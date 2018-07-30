﻿using NUnit.Framework;

using Xamarin.UITest;

using MobileAzureDevDays.Shared.Constants;

namespace MobileAzureDevDays.UITests
{
    public class SentimentTests : BaseTest
    {
        public SentimentTests(Platform platform) : base(platform)
        {
        }

		//[Test]
		//public void ReplTest()
		//{
		//	App.Repl();
		//}

        [Test]
        public void SentimentPage_SubmitHappyText_ResultShouldBeHappyFaceEmoji()
        {
            //Arrange
            const string happyText = "Happy";

			//Act
			LoginPage.TapLoginButton();
            SentimentPage.EnterText(happyText);
			SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.HappyFaceEmoji, SentimentPage.EmojiResultsText);
        }

        [Test]
        public void SentimentPage_SubmitSadText_ResultShouldBeSadFaceEmoji()
        {
            //Arrange
            const string sadText = "Sad";

            //Act
			LoginPage.TapLoginButton();
            
            SentimentPage.EnterText(sadText);
            SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.SadFaceEmoji, SentimentPage.EmojiResultsText);
        }

        [Test]
        public void SentimentPage_SubmitNeutralText_ResultShouldBeNeutralFaceEmoji()
        {
            //Arrange
            const string neutralText = "Mitigations in Seattle";

            //Act
			LoginPage.TapLoginButton();
            
            SentimentPage.EnterText(neutralText);
            SentimentPage.TapSubmitButton();
            SentimentPage.WaitForNoActivityIndicator();

            //Assert
            Assert.AreEqual(EmojiConstants.NeutralFaceEmoji, SentimentPage.EmojiResultsText);
        }
    }
}
