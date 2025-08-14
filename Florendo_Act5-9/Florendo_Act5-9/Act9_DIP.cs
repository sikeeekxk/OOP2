using System;

namespace Florendo_Act5_9
{
    internal class Act9_DIP
    {
        internal static void Run()
        {
            IMessageSender emailSender = new EmailMessageSender();
            NotificationService service = new NotificationService(emailSender);

            service.Send("Hello from DIP Example!");
        }
    }

    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class NotificationService
    {
        private readonly IMessageSender _messageSender;

        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Send(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
