using Homework_22.Models;
using Homework_22.Pages;
using NUnit.Allure.Core;

namespace Homework_22.Tests
{
    [AllureNUnit]
    internal class TextBoxPageTest : BaseTest
    {
        [TestCase("Test_User_123", "Test_Email_123@test.com", "Current_123", "Permanent_123")]

        [TestCase("Serious_User", "Serious_Email@jojo.com", "Variant_1", "Variant_2")]

        [TestCase("Supa_Dupa", "Not_email@NA.com", "Prefer_1", "Prefer_2")]

        public void EnterData(string name, string email, string currentAddress, string permanentAddress)
        {
            Person person = new Person(name, email, currentAddress, permanentAddress);
            TextBoxPage.FillTheForm(person);

            var result = TextBoxPage.CheckForm(person);
            Assert.That(result, Is.True);
        }
    }
}
