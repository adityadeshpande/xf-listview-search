using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchListView
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<object> _Items;
        private ObservableCollection<object> _ItemsFiltered;
        private ObservableCollection<object> _ItemsUnfiltered;
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged("SearchText");
            }
        }
        public ObservableCollection<object> Items
        {
            get { return _Items; }
            set
            {
                _Items = value;
                OnPropertyChanged("Items");
            }
        }

        #region Commands
        public ICommand SearchCommand { get; private set; }
        #endregion

        public MainPageViewModel()
        {
            FillDataInLists();
            SearchCommand = new Command(PerformSearch);
        }

        private void FillDataInLists()
        {
            var _listOfItems = new DataFactory().GetItems();
            _ItemsUnfiltered = new ObservableCollection<object>(_listOfItems);
            Items = new ObservableCollection<object>(_listOfItems);
        }

        public void PerformSearch()
        {
            if (string.IsNullOrWhiteSpace(this._searchText))
                Items = _ItemsUnfiltered;
            else
            {
                _ItemsFiltered = new ObservableCollection<object>(_ItemsUnfiltered
                                                .Where(i => (i is ItemObj && (((ItemObj)i)
                                                .Name.ToLower()
                                                .Contains(_searchText.ToLower())))));
                Items = _ItemsFiltered;
            }
        }
    }

    internal class DataFactory
    {
        public List<ItemObj> GetItems()
        {
            return new List<ItemObj>()
            {
                new ItemObj{ Id = 1, Name = "Isabelle Mcclain"},
                new ItemObj{ Id = 2, Name = "Ernesto Aguirre"},
                new ItemObj{ Id = 3, Name = "Imani Daniel"},
                new ItemObj{ Id = 4, Name = "Sariah Ballard"},
                new ItemObj{ Id = 5, Name = "Colten Ray"},
                new ItemObj{ Id = 6, Name = "Marissa Hernandez"},
                new ItemObj{ Id = 7, Name = "Byron Ramos"},
                new ItemObj{ Id = 8, Name = "Milagros Macdonald"},
                new ItemObj{ Id = 9, Name = "Tiara Hancock"},
                new ItemObj{ Id = 10, Name = "Josephine Ewing"},
                new ItemObj{ Id = 11, Name = "Giada Conner"},
                new ItemObj{ Id = 12, Name = "Taniyah Marshall"},
            };
        }
    }

    public class ItemObj
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
