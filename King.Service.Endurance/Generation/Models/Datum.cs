namespace Generation.Models
{
    using Microsoft.WindowsAzure.Storage.Table;
    using System;

    public class Datum : TableEntity
    {
        public int EveryMs
        {
            get;
            set;
        }
        public string ServiceName
        {
            get;
            set;
        }
        public DateTime LastRun
        {
            get;
            set;
        }
        public DateTime Now
        {
            get;
            set;
        }
    }
}