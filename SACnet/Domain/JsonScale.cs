using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class JsonScale
    {
        public string? Name { get; set; }
        public List<int> Steps { get; set; } = new List<int>();
    }
}
