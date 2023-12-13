using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIdemo.Models;
using System.Collections.ObjectModel;

namespace MAUIdemo.ViewModel
{
    public partial class DefaultViewModel : ObservableObject
    {
        ObservableCollection<Employee> Employees { get; set; }
        public DefaultViewModel()
        {
            Employees = new ObservableCollection<Employee> 
            {
                new Employee{ Id = 1, Name = "Bao1" },
                new Employee{ Id = 2, Name = "Bao2" },
                new Employee{ Id = 3, Name = "Bao3" }
            };
        }
    }
}
