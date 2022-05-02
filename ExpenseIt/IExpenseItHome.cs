using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ExpenseIt
{
    public interface IExpenseItHome
    {
        List<Person> ExpenseDataSource { get; set; }
        DateTime LastChecked { get; set; }
        string MainCaptionText { get; set; }
        ObservableCollection<string> PersonsChecked { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void InitializeComponent();
    }
}