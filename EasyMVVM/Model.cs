using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMVVM
{
    public class Model
    {
        readonly ObservableCollection<string> _data = new();
        public ObservableCollection<string> GetData()
        {
            _data.Add("First Entry");
            _data.Add("Second Entry");
            _data.Add("Third Entry");
            return _data;
        }
    }
}
