using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLoaderLab.Services
{
    public static class DataLoader
    {
        public static async Task LoadFromApiAsync()
        {
            Console.WriteLine("Loading from API...");
            await Task.Delay(3000); // Simulate API call delay (3 seconds)
            Console.WriteLine("API loading completed.");
        }

        public static async Task LoadFromFileAsync()
        {
            Console.WriteLine("Loading from File...");
            await Task.Delay(2000);
            Console.WriteLine("File loading completed.");
        }

        public static async Task LoadFromDatabaseAsync()
        {
            Console.WriteLine("Loading from Database...");
            await Task.Delay(4000);
            Console.WriteLine("Database loading completed.");
        }
    }
}
