namespace Generation
{
    using Generation.Models;
    using King.Service;
    using Microsoft.WindowsAzure.ServiceRuntime;

    public class WorkerRole : RoleEntryPoint
    {
        private RoleTaskManager<Config> manager = new RoleTaskManager<Config>(new Factory());

        public override void Run()
        {
            this.manager.Run();

            base.Run();
        }

        public override bool OnStart()
        {
            var config = new Config()
            {
                TableName = "telemerty",
                StorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=endurance;AccountKey=f8g4QSn8Zkco7DXK1yGbgi2n8r8NZCdu6sNWcZ8TDF0HczlKmPtgWTqYEnr6BOCF2NlwJzlMXmHeGJRB+HVjCA==;",
            };

            return this.manager.OnStart(config);
        }

        public override void OnStop()
        {
            this.manager.OnStop();

            base.OnStop();
        }
    }
}