using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PCTInvestTestApp
{
    public class RFIDLabel : ILabel
    {
        public string Id { get; set; } = string.Empty;
        public int Count { get; set; }

        public RFIDLabel(string id, int count)
        {
            this.Id = id.ToLower();
            this.Count = count; 
        }

        public override bool Equals(object? obj)
        {
            if (obj is RFIDLabel person) return Id.ToLower() == person.Id.ToLower();
            return false;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
