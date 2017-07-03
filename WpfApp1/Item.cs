using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class Item : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged RaisePropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion  INotifyPropertyChanged RaisePropertyChanged

        #region RowIdx (INotifyPropertyChanged Property)

        private int _RowIdx;

        public int RowIdx
        {
            get { return _RowIdx; }
            set
            {
                if (_RowIdx != null && _RowIdx.Equals(value)) return;
                _RowIdx = value;
                RaisePropertyChanged("RowIdx");

            }
        }

        #endregion RowIdx (INotifyPropertyChanged Property)

        #region ColumnIdx (INotifyPropertyChanged Property)

        private int _ColumnIdx;

        public int ColumnIdx
        {
            get { return _ColumnIdx; }
            set
            {
                if (_ColumnIdx != null && _ColumnIdx.Equals(value)) return;
                _ColumnIdx = value;
                RaisePropertyChanged("ColumnIdx");

            }
        }

        #endregion ColumnIdx (INotifyPropertyChanged Property)

        #region ColumnSpan (INotifyPropertyChanged Property)

        private int _ColumnSpan = 1;

        public int ColumnSpan
        {
            get { return _ColumnSpan; }
            set
            {
                if (_ColumnSpan != null && _ColumnSpan.Equals(value)) return;
                _ColumnSpan = value;
                RaisePropertyChanged("ColumnSpan");

            }
        }

        #endregion ColumnSpan (INotifyPropertyChanged Property)

        #region Name (INotifyPropertyChanged Property)

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != null && _Name.Equals(value)) return;
                _Name = value;
                RaisePropertyChanged("Name");

            }
        }

        #endregion Name (INotifyPropertyChanged Property)
    }


}
