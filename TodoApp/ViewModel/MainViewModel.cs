using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace TodoApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<string> Items { get; set; }
        //public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand TapCommand { get; }

        public MainViewModel() 
        {
            
            Items = new ObservableCollection<string>();
            //AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand<string>(Delete);
            TapCommand = new AsyncRelayCommand<string>(Tap);

        }
        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            //add item
            Text = string.Empty;
        }

        void Delete(string s) 
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{ nameof(DetailPage)}?Text={s}");
        }
    }
}
