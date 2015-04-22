namespace Generation
{
    using King.Service;
    using System;
    using System.Collections.Generic;

    public class Factory : ITaskFactory<Config>
    {
        public IEnumerable<IRunnable> Tasks(Config config)
        {
            throw new NotImplementedException();
        }
    }
}