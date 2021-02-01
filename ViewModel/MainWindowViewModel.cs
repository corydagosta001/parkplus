using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;
using System.Windows;
using System.Threading;
using ParkingApp.Event_Classes;
using ParkingApp.Views;
using ParkingApp.Model;
namespace ParkingApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ICommand _userclick;
        private ICommand _gotoDestinationCommand;
        private ICommand _gotoHomeCommand;
        private ICommand _gotoRetrieveCommand;
        private ICommand _gotoStoreCommand;
        private ICommand _gotoConfirmedStorage;
        private ICommand _gotoTest;
        private ICommand _gotoRetrieveCars;

        private object _currentView;
        private object _home;
        private object _login;
        private object _retrieve;
        private object _store;
        private object _ConfirmedStorage;
        private object _ConfirmedRetrieve;

        private string _displayedImagePath;
        private string _logo;
        private string _mode;
        private string _username = "Username";
        private string _userpassword = "Password";
        private string _userfirstname;
        private ObservableCollection<Vehicles> _myVehicles = new ObservableCollection<Vehicles>();
        private ObservableCollection<Vehicles> _allVehicles = new ObservableCollection<Vehicles>();
        private ObservableCollection<Vehicles> _carCollect = new ObservableCollection<Vehicles>();
        public MainWindowViewModel()
        {

            _home = new Home();
            _login = new login();
            _retrieve = new Retrieve();
            _store = new Store();
            _ConfirmedStorage = new ConfirmedStorage();
            _ConfirmedRetrieve = new ConfirmRetrieve();
            _logo = "Park Plug Logo.png";
            CurrentView = _home;
        }

        public ObservableCollection<Vehicles> MyVehicles
        {
            get;
            set;
        }

        public ObservableCollection<Vehicles> AllVehicles
        {
            get;
            set;
        }

        public ICommand GotoTest
        {
            get
            {
                return _gotoTest ?? (_gotoTest = new RelayCommand(
                   x =>
                   {
                       gotoT();
                   }));
            }
        }

        public void gotoT()
        {
            MessageBox.Show("hey");
        }

        public ICommand ConfirmedStorage
        {
            get
            {
                return _gotoConfirmedStorage ?? (_gotoConfirmedStorage = new RelayCommand(
                   x =>
                   {
                       gotoStorage();
                   }));
            }
        }

        public ICommand GotoRetrieveCars
        {
            get
            {
                _mode = "";
                return _gotoRetrieveCars ?? (_gotoRetrieveCars = new RelayCommand(
                   x =>
                   {
                       GotoRC();
                   }));
            }
        }


        public ICommand GotoHomeCommand
        {
            get
            {
                _mode = "";
                return _gotoHomeCommand ?? (_gotoHomeCommand = new RelayCommand(
                   x =>
                   {
                       GotoHome();
                   }));
            }
        }

        public ICommand GotoDestinationCommand
        {
            get
            {
                return _gotoDestinationCommand ?? (_gotoDestinationCommand = new RelayCommand(
                x =>
                {
                    GotoDestination();
                }));
            }
        }

        public ICommand GotoRetrieveCommand
        {
            get
            {
                return _gotoRetrieveCommand ?? (_gotoRetrieveCommand = new RelayCommand(
                   x =>
                   {
                       GotoLoginRetrieve();
                   }));
            }
        }

        public ICommand GotoStoreCommand
        {
            get
            {
                return _gotoStoreCommand ?? (_gotoStoreCommand = new RelayCommand(
                   x =>
                   {
                       GotoLoginStore();
                   }));
            }
        }

        public ICommand UserClick
        {
            get
            {
                return _userclick ?? (_userclick = new RelayCommand(
                   x =>
                   {
                       gotoUserClick();
                   }));
            }
        }



        public void gotoUserClick()
        {
            if (_username == "Username")
            {
                UserName = "";
            }
            if (_userpassword == "Password")
            {
                UserPassword = "";
            }
        }

        private async void GotoRC()
        {
            foreach(var i in MyVehicles)
            {
                foreach(var j in UserInformation.UserStoredVehicles)
                {
                    if(j.Make == i.Make)
                    {
                        j.isChecked = i.isChecked;
                    }
                }
            }
            CurrentView = _ConfirmedRetrieve;
            UserInformation.RetrieveCars();
            AllVehicles = UserInformation.GetAllVehicles();
            await Task.Run(() =>
            {
                Thread.Sleep(2500);
                CurrentView = _home;
            });

        }

        private async void gotoStorage()
        {
            if (UserInformation.checkForBays())
            {

                CurrentView = _ConfirmedStorage;
                UserInformation.StoreVehicles();
            }
            else
            {
                MessageBox.Show("There isn't enough storage at this time. Please try back later.");
            }
            AllVehicles = UserInformation.GetAllVehicles();
            await Task.Run(() =>
            {
                Thread.Sleep(2500);
                CurrentView = _home;
            });

        }
  
        private void GotoHome()
        {
            AllVehicles = UserInformation.GetAllVehicles() ;
            CurrentView = _home;
        }


        private void GotoLoginStore()
        {
                ScreenMode.Mode = "store";
                CurrentView = _login;
        }

        private void GotoLoginRetrieve()
        {
            ScreenMode.Mode = "retrieve";
            CurrentView = _login;
        }

        private void GotoDestination()
        {
            Boolean canPass = UserInformation.ValidateUser(UserName, UserPassword);
            if (canPass)
            {
                UserName = "";
                UserPassword = "";
                switch (ScreenMode.Mode)
                {
                    case "store":
                        CurrentView = _store;
                        break;
                    case "retrieve":
                        MyVehicles = UserInformation.GetUserVehicles();
                        UserFirstName = UserInformation.userFirstName;
                        CurrentView = _retrieve;
                        break;
                    default:
                        MessageBox.Show("Request Denied");
                        AllVehicles = UserInformation.GetAllVehicles();
                        CurrentView = _home;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Bad username or password.");
            }
        }

        private void GotoRetrieve()
        {
            CurrentView = _retrieve;
        }

        private void GotoStore()
        {
            CurrentView = _store;
        }

        public string Blank
        {
            get { return ""; }
        }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public string Mode
        {
            set
            {
                _mode = value;
            }
            get
            {
                string m = _mode;
                return _mode;
            }
        }

        public string DisplayedImagePath
        {
            get
            {
                _displayedImagePath = Directory.GetCurrentDirectory() + "\\images\\" + _logo;
                return _displayedImagePath;
            }
        }

        public string UserName
        {
            get
            {
                if (_username == "")
                {
                    _username = "Username";
                }
                return _username;
            }
            set
            {
                _username = value;
                if (value == "")
                {
                    _username = UserName;
                    OnPropertyChanged("Username");
                }
            }
        }

        public string UserPassword
        {
            get
            {
                if (_userpassword == "")
                {
                    _userpassword = "Password";
                }
                return _userpassword;
            }
            set
            {
                _userpassword = value;
                if (value == "")
                {
                    _userpassword = "Password";
                    OnPropertyChanged("UserPassword");
                }
            }
        }

        public string UserFirstName
        {
            get { return _userfirstname; }
            set 
            {
                _userfirstname = value;
                OnPropertyChanged("UserFirstName");
            }
        }

    }

}
