using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Retirement Planning Calculator\n");

        double currentAge=35;
        double retirementAge=65;
        double currentSavings=50000;
        double monthlyContribution=500;
        double annualReturn=0.07;

        Console.WriteLine($"Current Age        : {currentAge}");
        Console.WriteLine($"Retirement Age     : {retirementAge}");
        Console.WriteLine($"Current Savings    : ${currentSavings:F2}");
        Console.WriteLine($"Monthly Contribution : ${monthlyContribution:F2}");
        Console.WriteLine($"Annual Return      : {annualReturn*100:F1}%\n");

        int yearsToRetirement=(int)(retirementAge-currentAge);
        double retirementFund=CalculateRetirement(currentSavings, monthlyContribution, annualReturn, yearsToRetirement, 0);

        Console.WriteLine($"\nEstimated Retirement Fund: ${retirementFund:F2}");
        Console.WriteLine($"Contribution During Working Years: ${(monthlyContribution*12*yearsToRetirement):F2}");
        Console.WriteLine($"Investment Growth: ${(retirementFund-(currentSavings+monthlyContribution*12*yearsToRetirement)):F2}");

        Console.ReadLine();
    }

    static double CalculateRetirement(double savings, double monthly, double rate, int yearsLeft, int yearsPassed)
    {
        if(yearsPassed==yearsLeft)
            return savings;

        double monthlyRate=rate/12;
        savings+=monthly;
        savings*=(1+monthlyRate);

        Console.WriteLine($"Year {yearsPassed+1} : ${savings:F2}");

        return CalculateRetirement(savings, monthly, rate, yearsLeft, yearsPassed+1);
    }
}
