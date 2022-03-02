using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTherapy.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }
        private string _emailID;
        public string EmailID
        {
            get { return _emailID; }
            set { _emailID = value;
                OnPropertyChanged("EmailID");
            }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value;
                OnPropertyChanged("Address");
            }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
