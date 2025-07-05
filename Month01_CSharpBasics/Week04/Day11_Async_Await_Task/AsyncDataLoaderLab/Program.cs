
using AsyncDataLoaderLab.Services;

namespace AsyncDataLoaderLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting data loading...\n");

            // Start all loading tasks concurrently
            var apiTask = DataLoader.LoadFromApiAsync();
            var fileTask = DataLoader.LoadFromFileAsync();
            var databaseTak = DataLoader.LoadFromDatabaseAsync();

            await Task.WhenAll(apiTask, fileTask, databaseTak);

            Console.WriteLine("\nAll data sources have finished loading.");
        }
    }
}