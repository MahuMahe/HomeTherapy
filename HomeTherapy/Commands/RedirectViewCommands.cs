using HomeTherapy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeTherapy.Commands
{
    public class RedirectViewCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel model;
        public RedirectViewCommands(MainViewModel viewModel)
        {
            this.model = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        //done
        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Home")
            {
                model.SelectedViewModel = new UserHomeViewModel();
            }
            else if (parameter.ToString() == "Painting")
            {
                model.SelectedViewModel = new PaintingViewModel();
            }
            else if(parameter.ToString() == "Plumbing")
            {
                model.SelectedViewModel = new PlumbingViewModel();
            }
            else if(parameter.ToString() == "Gardening")
            {
                model.SelectedViewModel = new GardeningViewModel();
            }
            else if (parameter.ToString() == "Interior Design")
            {
                model.SelectedViewModel = new InteriorDesignViewModel();
            }
            else if (parameter.ToString() == "House Keeping")
            {
                model.SelectedViewModel = new HouseKeepingViewModel();
            }
            else if (parameter.ToString() == "Categories")
            {
                model.SelectedViewModel = new CategoriesViewModel();
            }
            else if (parameter.ToString() == "LoginPage")
            {
                model.SelectedViewModel = new LoginPageViewModel();
            }
            else if (parameter.ToString() == "AboutUs")
            {
                model.SelectedViewModel = new AboutUsViewModel();
            }
            else if (parameter.ToString() == "ContactUs")
            {
                model.SelectedViewModel = new ContactUsViewModel();
            }           
        }
    }
}
