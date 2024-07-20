using Homework_22.Models;
using Homework_22.WebElements;
using OpenQA.Selenium;

namespace Homework_22.Pages
{
    internal class TextBoxPage : BasePage
    {
        private static Element _fullNameField = new Element(By.XPath("//*[@id='userName']"));
        private static Element _emailField = new Element(By.XPath("//*[@id='userEmail']"));
        private static Element _currentAddressField = new Element(By.XPath("//*[@id='currentAddress' and @class='form-control']"));
        private static Element _permanentAddressField = new Element(By.XPath("//*[@id='permanentAddress' and @class='form-control']"));

        private static Element _submitButton = new Element(By.XPath("//*[@id='submit']"));

        private static Element _fullNameCheck = new Element(By.XPath("//*[@id='name']"));
        private static Element _emailCheck = new Element(By.XPath("//*[@id='email']"));
        private static Element _currentAddressCheck = new Element(By.XPath("//*[@id='currentAddress' and @class='mb-1']"));
        private static Element _permanentAddressCheck = new Element(By.XPath("//*[@id='permanentAddress' and @class='mb-1']"));

        public static void FillTheForm(Person person)
        {
            _fullNameField.SendValue(person.Name);
            _emailField.SendValue(person.Email);
            _currentAddressField.SendValue(person.CurrentAddress);
            _permanentAddressField.SendValue(person.PermanentAddress);
            _submitButton.ClickElement();
        }

        public static bool CheckForm(Person person)
        {
            if(_fullNameCheck.GetElementText().Contains(person.Name) && _emailCheck.GetElementText().Contains(person.Email) && _currentAddressCheck.GetElementText().Contains(person.CurrentAddress) && _permanentAddressCheck.GetElementText().Contains(person.PermanentAddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
