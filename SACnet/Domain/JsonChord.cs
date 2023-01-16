using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class JsonChord
    {
        public string? Name { get; set; }
        public string? Tag { get; set; }
        public List<int> Notes { get; set; } = new List<int>();        
    }
}
