namespace Edgias.DesignPatterns.Essentials
{
    using System;

    public class MailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            // Send email
            Disconnect();
        }

        public void Connect()
        {
            Console.WriteLine("Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected.");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticated.");
        }
    }
}