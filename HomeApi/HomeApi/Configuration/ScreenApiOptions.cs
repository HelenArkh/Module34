using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeApi.Configuration
{
    public class ScreenApiOptions
    {
        public long Capacity { get; set; }
        public string ServerName { get; set; }

        public StorageType StorageType { get; set; }
    }
}
