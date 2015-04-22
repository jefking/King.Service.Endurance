namespace Generation.Tasks
{
    using King.Service;

    public class Collector : RecurringTask
    {
        public Collector(int seconds)
            :base(15, seconds)
        {

        }

        public override void Run()
        {
        }
    }
}