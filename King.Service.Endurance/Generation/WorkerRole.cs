namespace Generation
{
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