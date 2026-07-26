using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Loan Calculator\n");

        double principalAmount=200000;
        double annualInterestRate=0.06;
        int loanTermYears=30;
        int numberOfPayments=loanTermYears*12;

        Console.WriteLine($"Principal Amount   : ${principalAmount:F2}");
        Console.WriteLine($"Annual Interest    : {annualInterestRate*100:F2}%");
        Console.WriteLine($"Loan Term          : {loanTermYears} Years\n");

        double monthlyRate=annualInterestRate/12;
        double monthlyPayment=(principalAmount*monthlyRate*(Math.Pow(1+monthlyRate, numberOfPayments)))/(Math.Pow(1+monthlyRate, numberOfPayments)-1);

        Console.WriteLine($"Monthly Payment    : ${monthlyPayment:F2}");

        double totalPayment=monthlyPayment*numberOfPayments;
        double totalInterest=totalPayment-principalAmount;

        Console.WriteLine($"Total Payment      : ${totalPayment:F2}");
        Console.WriteLine($"Total Interest     : ${totalInterest:F2}\n");

        DisplayAmortization(principalAmount, monthlyRate, monthlyPayment, numberOfPayments);

        Console.ReadLine();
    }

    static void DisplayAmortization(double balance, double monthlyRate, double payment, int months)
    {
        Console.WriteLine("First 12 Months Amortization");
        for(int i=1; i<=Math.Min(12, months); i++)
        {
            double interest=balance*monthlyRate;
            double principal=payment-interest;
            balance-=principal;
            Console.WriteLine($"Month {i}: Principal=${principal:F2} Interest=${interest:F2} Balance=${balance:F2}");
        }
    }
}
