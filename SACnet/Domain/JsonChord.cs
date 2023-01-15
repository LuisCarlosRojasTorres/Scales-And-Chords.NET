using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class JsonChord
    {
        public string? Name { get; set; }
        public string? Tag { get; set; }
        public List<int> notes { get; set; } = new List<int>();        
    }
}
