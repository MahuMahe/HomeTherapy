using HomeTherapy.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeTherapy.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectViewModel = new UserHomeViewModel();
        public BaseViewModel SelectedViewModel
        {
            get
            {
                return _selectViewModel;
            }
            set
            {
                _selectViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public ICommand RedirectViewCommands { get; set; }
        public MainViewModel()
        {
            RedirectViewCommands = new RedirectViewCommands(this);
        }
    }
}
