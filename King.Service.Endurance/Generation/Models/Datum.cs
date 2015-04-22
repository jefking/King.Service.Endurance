namespace Generation.Models
{
    using Microsoft.WindowsAzure.Storage.Table;

    public class Datum : TableEntity
    {
        public string EveryMs
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