using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAccount
{
    abstract class Account
    {
        public abstract void CalculateInterest();
    }
    class SavingAccount : Account
    {
        double principal_amount, rate_of_interest, no_of_days;

        public SavingAccount(double p, double r, double n)
        {
            principal_amount = p;
            rate_of_interest = r;
            no_of_days = n;
        }
        public override void CalculateInterest()
        {
            double interest = principal_amount * rate_of_interest * no_of_days;
            Console.WriteLine("Interest on Saving Account: " + interest);
        }
    }
    class CurrentAccount : Account
    {
        double principal_amount, rate_of_interest, no_of_years;

        public CurrentAccount(double p, double r, double n)
        {
            principal_amount = p;
            rate_of_interest = r;
            no_of_years = n;
        }
        public override void CalculateInterest()
        {
            double interest = principal_amount * rate_of_interest * no_of_years;
            Console.WriteLine("Interest on Current Account Balance: " + interest);
        }
    }

    class FD : Account
    {
        double principal_amount, rate_of_interest, no_of_years;

        public FD(double p, double r, double n)
        {
            principal_amount = p;
            rate_of_interest = r;
            no_of_years = n;
        }
        public override void CalculateInterest()
        {
            double interest = principal_amount + (principal_amount * rate_of_interest * (no_of_years / 100));
            Console.WriteLine("Interest on Fixed Deposite : " + interest);
        }
    }

    class Program
    {
        public void FindInterest(Account a)
        {
            a.CalculateInterest();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            SavingAccount s = new SavingAccount(20000, 0.01, 7);
            CurrentAccount c = new CurrentAccount(2000, 0.02, 9);
            FD fd = new FD(25000, 6, 15);
            p.FindInterest(s);
            p.FindInterest(c);
            p.FindInterest(fd);

            Console.ReadKey();

        }
    }
}