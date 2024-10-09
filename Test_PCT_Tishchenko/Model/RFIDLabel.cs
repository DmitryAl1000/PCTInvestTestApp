using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PCTInvestApp
{
    public class RFIDLabel : ILabel
    {
        public string Id { get; set; } = string.Empty;
        public string RFIDName { get; set; } = string.Empty;
        public int Count { get; set; }

        public RFIDLabel(string id, string RFIDName, int count)
        {
            this.Id = id.ToUpper();
            this.RFIDName = RFIDName;
            this.Count = count; 
        }




        public override bool Equals(object? obj)
        {
            if (obj is RFIDLabel person) return Id.ToUpper() == person.Id.ToUpper();
            return false;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
