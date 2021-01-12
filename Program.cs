using System;
using Edgias.DesignPatterns.Essentials;
using Edgias.DesignPatterns.Memento;

namespace Edgias.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Memento();
        }

        static void Greet(string name)
        {
            User user = new User(name);
            user.SayHello();
        }

        static void Transact()
        {
            Account account = new Account();
            account.Deposit(10000);
            account.Withdraw(500);
            Console.WriteLine(account.Balance);
        }

        static void CalculateTax()
        {
            ITaxCalculator calculator = GetCalculator();
            decimal salary = 20000M;
            decimal tax = calculator.CalculateTax(salary);
            Console.WriteLine(tax);
        }

        static ITaxCalculator GetCalculator()
        {
            return new TaxCalculator2019();
        }

        static void Memento()
        {
            Editor editor = new Editor();
            History history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}
