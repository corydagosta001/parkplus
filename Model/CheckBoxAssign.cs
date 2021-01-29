using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.Event_Classes;
namespace ParkingApp.Model
{


    public class CheckBoxModel : ViewModelBase1
    {
        private string _label;
        private string _name;
        private Boolean _checked;
        public CheckBoxModel(string l,string n, Boolean c)
        {
           Label = l;
            Name = n;
            Checked = c;
        }
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public Boolean Checked
        {
            get { return _checked; }
            set 
            { 
                _checked = value;
                OnPropertyChanged("Checked");
            }
        }
    }
}
