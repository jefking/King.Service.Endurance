namespace Generation
{
    using Generation.Models;
    using King.Azure.Data;
    using King.Service;
    using King.Service.Data;
    using System.Collections.Generic;

    public class Factory : ITaskFactory<Config>
    {
        public IEnumerable<IRunnable> Tasks(Config config)
        {
            var table = new TableStorage(config.TableName, config.StorageConnectionString);
            yield return new InitializeStorageTask(table);
        }
    }
}