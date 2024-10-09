using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTInvestApp
{
    public interface ILabel
    {
        public string Id { get; set; }
        public string RFIDName { get; set; }
        public int Count { get; set; }

    }
}
