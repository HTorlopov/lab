namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense applicationLicense = new ApplicationLicense();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(applicationLicense.Status);
                Console.WriteLine("Enter license key - [trial/pro] XXXXXXXX");

                string[] msg = Console.ReadLine().Split(" ");
                if (msg.Length == 1)
                {
                    applicationLicense.AllowCommon();
                    continue;
                }

                switch (msg[0])
                {
                    case "trial":
                        if (!applicationLicense.AllowTrial(msg[1]))
                            Console.WriteLine("error");                       
                        break;
                    case "pro":
                        if (!applicationLicense.AllowPro(msg[1]))
                            Console.WriteLine("error");
                        break;

                    default:
                        applicationLicense.AllowCommon();
                        break;

                }

                Console.WriteLine("...");
                Console.ReadLine();
            }
        }
    }
}