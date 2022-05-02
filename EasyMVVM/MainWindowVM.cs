using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EasyMVVM;

namespace EasyMVVM
{
    internal class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            Model m = new();
            BoundProperty = m.GetData();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<string> _BackingProperty;

        public ObservableCollection<string> BoundProperty
        {
            get { return _BackingProperty; }
            set { _BackingProperty = value; PropChanged(nameof(BoundProperty)); }
        }

        public void PropChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}