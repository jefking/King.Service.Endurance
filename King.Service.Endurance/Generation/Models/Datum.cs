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
        public long LastRun
        {
            get;
            set;
        }
        public long Now
        {
            get;
            set;
        }
    }
}