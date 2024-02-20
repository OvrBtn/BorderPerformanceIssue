using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderPerformanceIssue
{
    public class SharedViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselObject> Items
        {
            get => items;
            set
            {
                items = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            }
        }
        ObservableCollection<CarouselObject> items = new();

        public event PropertyChangedEventHandler? PropertyChanged;

        public SharedViewModel()
        {
            Random random = new();
            for (int i = 0; i < 50; i++)
            {
                Items.Add(new());
                for (int j = 0; j < 50; j++)
                {
                    Items[i].ItemsCollection.Add(new SingleItem() { Text = random.Next(1000, 100000).ToString() });
                }
                Items[i].ItemsCollection[0] = new SingleItem() { Text = i.ToString() };
            }
        }
    }

    public class CarouselObject
    {
        public ObservableCollection<SingleItem> ItemsCollection { get; set; } = new();
    }

    public class SingleItem
    {
        public string Text { get; set; }
    }
}
