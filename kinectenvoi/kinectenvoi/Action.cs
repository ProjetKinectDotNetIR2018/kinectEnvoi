using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinectenvoi
{
    public class Action
    {
        public string url { get; set; }
        public string verb { get; set; }
        public List<Header> headers { get; set; }
        public object payload { get; set; }
        
    }
}
