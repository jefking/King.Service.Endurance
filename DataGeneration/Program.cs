namespace DataGeneration
{
    using Generation;
    using Generation.Models;
    using King.Service;
    using Microsoft.Azure.WebJobs;

    class Program
    {
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