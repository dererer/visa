using mevoronin.RuCaptchaNETClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            RuCaptchaClient capClient = new RuCaptchaClient("a8033d2fa483a2d3b9fa0c001417f672");

            string capId = capClient.UploadCaptchaFile("C://test.jpg");

            for (int i = 0; i < 20 * 3000; i++)
            {
                try
                {
                    Console.WriteLine("Result -> " + capClient.GetCaptcha(capId));

                    break;
                }

                catch
                {
                    System.Threading.Thread.Sleep(3000);
                }
            }
            

            Console.WriteLine("Balence -> " + capClient.GetBalance());

            Console.ReadKey(); 
        }
    }
}
