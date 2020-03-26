using System;
using Limilabs.Mail;
using Limilabs.Mail.MSG;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "ImageTestDownload.msg";

            IMail msg;

            using (var converter = new MsgConverter(filePath))
            {
                msg = converter.CreateMessage();
            }

            Console.WriteLine(msg.Subject);
            Console.ReadLine();
        }
    }
}
