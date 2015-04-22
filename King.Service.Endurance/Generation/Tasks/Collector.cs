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

        public Collector(int seconds, ITableStorage table)
            :base(15, seconds)
        {
            this.seconds = seconds;
            this.table = table;
        }

        public override void Run()
        {
            var entity = new Datum();
            entity.PartitionKey = string.Format("{0}", this.seconds);
            entity.RowKey = DateTime.UtcNow.ToString();
            entity.EveryTotalMilliseconds = base.Every.TotalMilliseconds;
            entity.ServiceName = base.ServiceName;

            this.table.InsertOrReplace(entity);
        }
    }
}