using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models.ResponceModel
{
    public class Response
    {
        public string status { get; set; }
        public string message { get; set; }
        public object payload { get; set; }
    }
    
}
