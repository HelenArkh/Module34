using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models
{
    public class AddDiskRequest
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Capacity { get; set; }
    }
}
