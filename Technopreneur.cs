using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Technopreneur : Person, IEntrepreneur
    {
        public Technopreneur() {
            BusinessName = "Unknown";
            BusinessType = "Unknown";
            InvestmentAmount = 0.0;
            YearsInBusiness = 0;
        }
        public Technopreneur(int id, string name, string city, int age, 
            int entrepreneurId, string businessName, string businessType, double investmentAmount, int yearsInBusiness)
            : base(id, name, city, age)
        {
            EntrepreneurId = entrepreneurId;
            BusinessName = businessName;
            BusinessType = businessType;
            InvestmentAmount = investmentAmount;
            YearsInBusiness = yearsInBusiness;
        }

        // Properties from IEntrepreneur interface
        public int EntrepreneurId { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessType { get; set; }
        public double InvestmentAmount { get; set; }
        public int YearsInBusiness { get; set; }

        // Method to display entrepreneur details
        public void DisplayEntrepreneurDetails()
        {
            Console.WriteLine($"Entrepreneur ID: {EntrepreneurId}");
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Business Type: {BusinessType}");
            Console.WriteLine($"Investment Amount: {InvestmentAmount:C}");
            Console.WriteLine($"Years in Business: {YearsInBusiness}");
            base.DisplayPersonDetails();
        }
        // Method to get entrepreneur information as a string
        public string GetEntrepreneurInfo()
        {
            return $"Entrepreneur ID: {EntrepreneurId}, Business Name: {BusinessName}, Business Type: {BusinessType}, " +
                   $"Investment Amount: {InvestmentAmount:C}, Years in Business: {YearsInBusiness}";
                   base.GetPersonInfo(); //Call the base class method to get person info
        }
    }
}
