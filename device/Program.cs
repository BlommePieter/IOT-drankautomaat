using System.Text;
using machineapp.Models;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;


string connectionString = "";
var deviceClient = DeviceClient.CreateFromConnectionString(connectionString);


#region Menu

await Loop();
async Task Loop()
{
    while (true)
    {
        Console.WriteLine("Maak uw keuze: ");
        Console.WriteLine("1. Water");
        Console.WriteLine("2. Cola");
        Console.WriteLine("3. Fruitsap");
        Console.WriteLine("4. Afsluiten");
        string keuze = Console.ReadLine();
        await ProcessChoice(keuze);
    }
}
async Task ProcessChoice(string choise)
{
}

#endregion
