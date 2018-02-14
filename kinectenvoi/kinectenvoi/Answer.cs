using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinectenvoi
{
    public class Answer
    {
        private string v;
        private object p1;
        private object p2;

        public Answer(string v, object p1, object p2)
        {
            this.v = v;
            this.p1 = p1;
            this.p2 = p2;
        }

        public string code { get; set; }
        public List<Label> summary { get; set; }
        public Action action {get;set;}
    }
}
