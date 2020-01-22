using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAraxni
{
    class Spider
    {
        public double weight;
        public double length;
        public string type;
    }

    public Spider() { }
    public Spider(double weight, double length, string type)
    {
        this.weight = weight;
        this.length = length;
        this.type = type;
    }
}
