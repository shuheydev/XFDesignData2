using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XFDesignData2.Models
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }

        private ObservableCollection<People> _members;
        public ObservableCollection<People> Members
        {
            get => _members;
            set
            {
                if (_members == value) return;
                _members = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
