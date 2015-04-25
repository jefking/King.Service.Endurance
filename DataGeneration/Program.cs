namespace DataGeneration
{
    using Generation;
    using Generation.Models;
    using King.Service;
    using Microsoft.Azure.WebJobs;

    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            var config = new Config()
            {
                TableName = "telemerty",
                StorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=endurance;AccountKey=f8g4QSn8Zkco7DXK1yGbgi2n8r8NZCdu6sNWcZ8TDF0HczlKmPtgWTqYEnr6BOCF2NlwJzlMXmHeGJRB+HVjCA==;",
            };
            var manager = new RoleTaskManager<Config>(new Factory());
            manager.OnStart(config);
            
            var host = new JobHost();
            manager.Run();
            
            host.RunAndBlock();

            manager.OnStop();
        }
    }
}