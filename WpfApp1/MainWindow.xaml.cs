using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {

        #region INotifyPropertyChanged RaisePropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion  INotifyPropertyChanged RaisePropertyChanged

        #region ViewModel (INotifyPropertyChanged Property)

        private ViewModel _ViewModel;

        public ViewModel ViewModel
        {
            get { return _ViewModel; }
            set
            {
                if (_ViewModel != null && _ViewModel.Equals(value)) return;
                _ViewModel = value;
                RaisePropertyChanged("ViewModel");

            }
        }

        #endregion ViewModel (INotifyPropertyChanged Property)

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

            ViewModel = new ViewModel();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           ViewModel?.InitData();
        }


    }


}
