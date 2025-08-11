using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal interface IEntrepreneur
    {
        int EntrepreneurId { get; set; }
        string? BusinessName { get; set; }
        string? BusinessType { get; set; }

        double InvestmentAmount { get; set; }
        int YearsInBusiness { get; set; }

        void DisplayEntrepreneurDetails();
        string GetEntrepreneurInfo();
    }
}
