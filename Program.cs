using System;
using System.IO;


namespace w600_download_tool
{
    internal class Program
    {
        
        private static int Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("usage: w600_download_tool.exe <filename> <port> <baud>");
                Console.WriteLine("error: too few arguments");
                return -1;
            }

            string filepath = args[0];
            string portname = args[1];
            string baudrate = args[2];

            int baudrate_index = 4;
            
            switch(baudrate)
            {
                case "2000000":
                    baudrate_index = 0;
                    break;
                case "1000000":
                    baudrate_index = 1;
                    break;
                case "921600":
                    baudrate_index = 2;
                    break;
                case "460800":
                    baudrate_index = 3;
                    break;
                default:
                    baudrate_index = 4;
                    break;
            }
            
            if(File.Exists(filepath) == false)
            {
                Console.WriteLine("Error firmware path !");
            }
            var controller = new W600Controller();
            try
            {
                controller.Open(portname);
                Console.WriteLine("opend {0} !", portname);
                controller.Sync_To_Download(baudrate_index);
                controller.LoadFirmware(filepath);
                Console.WriteLine("All done.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }

            return 0;
            
        }
    }
}