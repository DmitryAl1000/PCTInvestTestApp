using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PCTInvestTestApp
{
    public class GetSendFormViewModel : INotifyPropertyChanged
    {



        private BindingList<IProduct> _productsVeiw;
        public BindingList<IProduct> ProductsVeiw
        {
            get { return _productsVeiw; }
            set
            {
                _productsVeiw = value;
                OnPropertyChanged("ProductsVeiw");
            }
        }





        public GetSendFormViewModel()
        {

            ProductsVeiw = new();
            DeclareComands();
        }

        private void DeclareComands()
        {





        }



        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
