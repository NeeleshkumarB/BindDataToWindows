using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindDataToWindows
{
    class DataPoint : INotifyPropertyChanged
    {

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value;
                OnPropertyChanged("Value");
            }
        }


        #region INotifyPropertyChanged Members
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion
    }
}
