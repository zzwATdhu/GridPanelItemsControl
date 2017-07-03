using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ViewModel:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged RaisePropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion  INotifyPropertyChanged RaisePropertyChanged


        #region RowCount (INotifyPropertyChanged Property)

        private int _RowCount;

        public int RowCount
        {
            get { return _RowCount; }
            set
            {
                if (_RowCount != null && _RowCount.Equals(value)) return;
                _RowCount = value;
                RaisePropertyChanged("RowCount");

            }
        }

        #endregion RowCount (INotifyPropertyChanged Property)


        #region ColumnCount (INotifyPropertyChanged Property)

        private int _ColumnCount;

        public int ColumnCount
        {
            get { return _ColumnCount; }
            set
            {
                if (_ColumnCount != null && _ColumnCount.Equals(value)) return;
                _ColumnCount = value;
                RaisePropertyChanged("ColumnCount");

            }
        }

        #endregion ColumnCount (INotifyPropertyChanged Property)


        #region StarColumns (INotifyPropertyChanged Property)

        private string _StarColumns;

        public string StarColumns
        {
            get { return _StarColumns; }
            set
            {
                if (_StarColumns != null && _StarColumns.Equals(value)) return;
                _StarColumns = value;
                RaisePropertyChanged("StarColumns");

            }
        }

        #endregion StarColumns (INotifyPropertyChanged Property)


        #region ItemCollection (INotifyPropertyChanged Property)

        private ObservableCollection<Item> _ItemCollection;

        public ObservableCollection<Item> ItemCollection
        {
            get { return _ItemCollection; }
            set
            {
                if (_ItemCollection != null && _ItemCollection.Equals(value)) return;
                _ItemCollection = value;
                RaisePropertyChanged("ItemCollection");

            }
        }

        #endregion ItemCollection (INotifyPropertyChanged Property)


        #region Methods

        public void InitData()
        {
            var items = new ObservableCollection<Item>
            {
                new Item()
                {
                    RowIdx = 0,
                    ColumnIdx = 0,
                    Name = "节点1"
                },
                new Item()
                {
                    RowIdx = 0,
                    ColumnIdx = 2,
                    Name = "节点2"
                },
                new Item()
                {
                    RowIdx = 1,
                    ColumnIdx = 1,
                    ColumnSpan = 2,
                    Name = "节点3"
                },
                new Item()
                {
                    RowIdx = 2,
                    ColumnIdx = 2,
                    Name = "节点4"
                }
            };


            foreach (var item in items)
            {
                if (item.RowIdx > RowCount)
                    RowCount = item.RowIdx;
                if (item.ColumnIdx > ColumnCount)
                    ColumnCount = item.ColumnIdx;
            }



            RowCount = RowCount + 1;
            ColumnCount = ColumnCount + 1;
            StarColumns = string.Join(",", Enumerable.Range(0, ColumnCount));
            ItemCollection = items;
        }

        #endregion 
    }
}
