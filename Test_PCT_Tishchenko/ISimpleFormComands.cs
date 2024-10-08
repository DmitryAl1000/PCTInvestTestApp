using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTInvestTestApp
{
    public interface ISimpleFormComands
    {
        public void showMessege(string str);

        public void showErrorMessege(string str);

        public bool IsYesOrNoShowMessge(string str);

        public void CloseForm();

    }

}
