using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using NPPES_Entities;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using TestProviderData;

internal class Program
{
    private static void Main(string[] args)
    {
        
        new ProviderOtherNameLoad().Load();
        new ProviderPracticeLocationLoad().Load();
        new ProviderEndpointLoad().Load();
        new ProviderLoad().Load();

        Console.WriteLine("Complete.  Press any key to exit.");
        Console.ReadKey();
    }
}