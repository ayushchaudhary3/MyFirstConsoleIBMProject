using System;

namespace MyFirstConsoleIBMProject
{
    // Base class: Telephone
    internal class Telephone
    {
        public void Call(string number)
        {
            Console.WriteLine($"Calling {number} from Telephone...");
        }
    }

    // Derived class: SimpleMobilePhone inherits from Telephone
    internal class SimpleMobilePhone : Telephone
    {
        public void SendSMS(string number, string message)
        {
            Console.WriteLine($"Sending SMS to {number}: {message}");
        }
    }

    // Derived class: SmartPhone inherits from SimpleButtonMobilePhone
    internal class SmartPhone : SimpleMobilePhone
    {
        public void BrowseInternet(string url)
        {
            Console.WriteLine($"Browsing: {url}");
        }
    }

    // Example usage
    internal class MultilevelInheritence
    {
        public static void Demo()
        {
            SmartPhone myPhone = new SmartPhone();
            myPhone.Call("1234567890"); // Inherited from Telephone
            myPhone.SendSMS("1234567890", "Hello!"); // Inherited from SimpleButtonMobilePhone
            myPhone.BrowseInternet("https://github.com"); // SmartPhone's own method
        }
    }
}
