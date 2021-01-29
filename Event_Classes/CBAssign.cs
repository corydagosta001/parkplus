using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ParkingApp.Model;



namespace ParkingApp.Event_Classes
{
    public class CBAssign : ViewModelBase
    {
        public ObservableCollection<CheckBoxModel> _cbm = new ObservableCollection<CheckBoxModel>();
        public CBAssign()
        {
            CheckBoxModel a = new CheckBoxModel("Vehicle is turned off", "off", false);
            _cbm.Add(a);
            CheckBoxModel b = new CheckBoxModel("Vehicle in park", "park", false);
            _cbm.Add(b);
            CheckBoxModel c = new CheckBoxModel("All people, pets and required items have been removed from the vehicle", "removed", false);
            _cbm.Add(c);
            CheckBoxModel d = new CheckBoxModel("Parking brake is set", "brake", false);
            _cbm.Add(d);
        }

    }
}
