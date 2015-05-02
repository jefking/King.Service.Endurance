namespace Generation.Tasks
{
    using Generation.Models;
    using King.Azure.Data;
    using King.Service;
    using System;

    public class Collector : RecurringTask
    {
        private readonly ITableStorage table;
        private readonly int seconds = 0;
        private DateTime? lastRun = null;

        public Collector(int seconds, ITableStorage table)
            :base(15, seconds)
        {
            this.seconds = seconds;
            this.table = table;
        }

        public override void Run()
        {
            var now = DateTime.UtcNow;

            if (lastRun.HasValue)
            {
                var entity = new Datum()
                {
                    PartitionKey = string.Format("{0}", this.seconds),
                    RowKey = Guid.NewGuid().ToString(),
                    EveryMs = (int)base.Every.TotalMilliseconds,
                    ServiceName = base.ServiceName,
                    Now = now.Ticks,
                    LastRun = lastRun == null ? 0 : lastRun.Value.Ticks,
                };

                this.table.InsertOrReplace(entity).Wait();
            }

            this.lastRun = now;
        }
    }
}