namespace Generation.Models
{
    using Microsoft.WindowsAzure.Storage.Table;

    public class Datum : TableEntity
    {
        public double EveryTotalMilliseconds
        {
            get;
            set;
        }
        public string ServiceName
        {
            get;
            set;
        }
    }
}
