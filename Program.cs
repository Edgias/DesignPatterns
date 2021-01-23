using System;
using Edgias.DesignPatterns.Essentials;
using Edgias.DesignPatterns.Memento;
using Edgias.DesignPatterns.Iterator;
using Edgias.DesignPatterns.Strategy;
using Edgias.DesignPatterns.Template;
using Edgias.DesignPatterns.Command;
using Edgias.DesignPatterns.Command.Framework;

namespace Edgias.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Command();
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

        static void Iterator()
        {
            BrowserHistory browserHistory = new BrowserHistory();
            browserHistory.Push("edgias.com");
            browserHistory.Push("apps.edgias.com");
            browserHistory.Push("sales.edgias.com");

            IIterator iterator = browserHistory.CreateIterator();
            while(iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }

        static void Strategy()
        {
            JpegCompressor compressor = new JpegCompressor();
            BlackAndWhiteFilter filter = new BlackAndWhiteFilter();
            ImageStorage imageStorage = new ImageStorage(compressor, filter);

            imageStorage.Store("Video File");
        }

        static void Template()
        {
            TransferMoney transferMoney = new TransferMoney();
            transferMoney.Execute();
        }

        static void Command()
        {
            CustomerService customerService = new CustomerService();
            AddCustomerCommand addCustomerCommand = new AddCustomerCommand(customerService);
            Button button = new Button(addCustomerCommand);
            button.Click();
        }
    }
}
