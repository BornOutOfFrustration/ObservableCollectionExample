using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionExample
{
    public class ViewModel
    {
        private ObservableCollection<ItemViewModel> LocalCollection = new ObservableCollection<ItemViewModel>();

        public ObservableCollection<ItemViewModel> TheCollection => this.LocalCollection;
    }

    public class ItemViewModel : INotifyPropertyChanged
    {
        private string LocalName;
        private string LocalTelephoneNumber;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name {
            get => this.LocalName;
            set
            {
                if (value != this.LocalName)
                {
                    this.LocalName = value;
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        public string TelephoneNumber {
            get => this.LocalTelephoneNumber;
            set 
            {
                if (value != this.LocalTelephoneNumber)
                {
                    this.LocalTelephoneNumber = value;
                    OnPropertyChanged(nameof(TelephoneNumber));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
