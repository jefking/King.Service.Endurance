namespace Generation.Tasks
{
    using King.Azure.Data;
using King.Service;

    public class Collector : RecurringTask
    {
        private readonly ITableStorage table;

        public Collector(int seconds, ITableStorage table)
            :base(15, seconds)
        {
            this.table = table;
        }

        public override void Run()
        {
        }
    }
}