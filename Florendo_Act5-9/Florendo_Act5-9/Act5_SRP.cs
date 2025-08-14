using System;

namespace Florendo_Act5_9
{
    internal class Act5_SRP
    {
        internal static void Run()
        {
            ReportGenerator report = new ReportGenerator();
            FileSaver saver = new FileSaver();
            EmailSender sender = new EmailSender();

            report.GenerateReport("PDF");
            saver.SaveToFile("Report content...");
            sender.SendEmail("student@example.com");
        }
    }

    public class ReportGenerator
    {
        public void GenerateReport(string reportType)
        {
            if (reportType == "PDF")
                Console.WriteLine("Generating PDF Report");
            else if (reportType == "Excel")
                Console.WriteLine("Generating Excel Report");
        }
    }

    public class FileSaver
    {
        public void SaveToFile(string content)
        {
            Console.WriteLine("Saving report to file...");
        }
    }

    public class EmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending report to {email}");
        }
    }
}
