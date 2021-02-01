using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
namespace ParkingApp.Model
{
    static public class UserInformation
    {
        static List<People> UserInfo = new List<People>();
        static List<Vehicles> Vehicle= new List<Vehicles>();
        static List<Vehicles> UserStoredVehicles = new List<Vehicles>();
        static List<int> removeList = new List<int>();
        static List<BayModel> bayModel = new List<BayModel>();
        static public string userFirstName;
        static int sub = 0;
        static Nullable<int> CurrentUser = null;
        static Boolean d = true;
        static UserInformation()
        { }

        static public void StoreVehicles()
        {
            sub = 0;
            removeList.Clear();
            foreach (var i in UserStoredVehicles)
            {
                if (i.ID == CurrentUser)
                {
                    removeList.Add(sub);
                }
                sub++;
            }
            sub -= 1;
            removeList.Sort();
            removeList.Reverse();
            foreach (int i in removeList)
            {
                UserStoredVehicles.RemoveAt(i);
            }
            foreach (var i in Vehicle)
            {
                if (i.ID == CurrentUser)
                {
                    foreach(var g in bayModel)
                    {
                        if(g.available == true)
                        {
                            i.bay = g.Bay;
                            g.available = false;
                            break;
                        }
                    }
                    UserStoredVehicles.Add(i);
                }
            }

        }

        static public void RetrieveCars()
        {

            List<string> b = new List<string>();
            sub = 0;
            removeList.Clear();
            foreach (var i in UserStoredVehicles)
            {
                b.Add(i.bay);
            }
            foreach(string i in b)
            {
                foreach(var l in bayModel)
                {
                   if(l.Bay == i)
                   {
                        l.available = true;
                   }
                }
            }
            foreach (var i in UserStoredVehicles)
            {
                if (i.ID == CurrentUser)
                {
                    removeList.Add(sub);
                }
                sub++;
            }
            sub -= 1;
            removeList.Sort();
            removeList.Reverse();
            foreach (int i in removeList)
            {
                UserStoredVehicles.RemoveAt(i);
            }
        }

        public static Boolean checkForBays()
        {
            int c_amount = 0;
            int a_amount = 0;
            foreach(var i in Vehicle)
            {
                if(i.ID == CurrentUser)
                {
                    c_amount++;
                }
            }
            foreach(var i in bayModel)
            {
                if(i.available == true)
                {
                    a_amount++;
                }
            }
            return c_amount <= a_amount ? true : false;
        }


        public static ObservableCollection<Vehicles> GetUserVehicles()
        {
            ObservableCollection<Vehicles> uv = new ObservableCollection<Vehicles>();
            foreach(var i in UserStoredVehicles)
            {
                if(i.ID == CurrentUser)
                {
                    uv.Add(LoadVehicle1(i.ID, i.Make, i.Model, i.Year, i.bay));
                }
            }
            return uv;
        }

        public static ObservableCollection<Vehicles> GetAllVehicles()
        {
            ObservableCollection<Vehicles> uv = new ObservableCollection<Vehicles>();
            foreach (var i in UserStoredVehicles)
            {
                uv.Add(LoadVehicle1(i.ID, i.Make, i.Model, i.Year,i.bay));
            }
            return uv;
        }

        public static Boolean ValidateUser(string userlogin, string password)
        {
            Boolean canPass = false;
            FillList();
            foreach(var i in UserInfo)
            {
                if(userlogin == i.UserLogin && password == i.UserPassword)
                {
                    canPass = true;
                    CurrentUser = i.ID;
                    userFirstName = i.FirstName;
                    break;
                }
            }
            return canPass;
        }

        static public void FillList()
        {
            if(UserInfo.Count == 0)
            {
                for(int a =0;a<4;a++)
                {
                    addRecords(a);
                }
            }

        }

        static private void addRecords(int b)
        {
            People p = new People();
            loadBayList();
            p.ID = b + 1;
            switch (b)
            {
                case 0:
                    p.FirstName = "Paul";
                    p.LastName = "Bates";
                    p.UserLogin = "Paul_Bates";
                    p.UserPassword = "123";
                    break;
                case 1:
                    p.FirstName = "Lyle";
                    p.LastName = "Smith";
                    p.UserLogin = "Lyle_Smith";
                    p.UserPassword = "234";
                    break;
                case 2:
                    p.FirstName = "Thomas";
                    p.LastName = "Portesy";
                    p.UserLogin = "Thomas_Portesy";
                    p.UserPassword = "345";
                    break;
                case 3:
                    p.FirstName = "Cory";
                    p.LastName = "D'Agosta";
                    p.UserLogin = "Cory_D'Agosta";
                    p.UserPassword = "456";
                    break;
            }
            UserInfo.Add(p);
            AddVehicles(b);
        }

        static public void AddVehicles(int c)
        {
            Vehicles v = new Vehicles();
            switch (c)
            {
                case 0:
                    Vehicle.Add(LoadVehicle(c + 1, "Bugatti", "Veyron", "2015"));
                    Vehicle.Add(LoadVehicle(c + 1, "Lamborghini", "Terzo", "2019"));
                    Vehicle.Add(LoadVehicle(c + 1, "Chevrolet", "Chevette", "1987"));
                    break;
                case 1:
                    Vehicle.Add(LoadVehicle(c + 1, "Toyota", "Camry", "2007"));
                    Vehicle.Add(LoadVehicle(c + 1, "Lexus", "RX", "2021"));
                    break;
                case 2:
                    Vehicle.Add(LoadVehicle(c + 1, "Chevrolet", "Chevelle","1970"));
                    break;
                case 3:
                    Vehicle.Add(LoadVehicle(c + 1, "Flintstones Car", "NA", "5000bc"));
                    break;
            }
        }

        static private Vehicles LoadVehicle(int id, string make, string model, string year)
        {
            Vehicles v = new Vehicles();
            v.ID = id;
            v.Make = make;
            v.Model = model;
            v.Year = year;
            v.Empty = "";
            return v;
        }

        static private Vehicles LoadVehicle1(int id, string make, string model, string year, string bay)
        {
            Vehicles v = new Vehicles();
            v.ID = id;
            v.Make = make;
            v.Model = model;
            v.Year = year;
            v.bay = bay;
            v.Empty = "";
            return v;
        }

        static void loadBayList()
        {
            if (d == true)
            {
                bayModel.Add(insertBays("A1"));
                bayModel.Add(insertBays("A2"));
                bayModel.Add(insertBays("A3"));
                bayModel.Add(insertBays("A4"));
                bayModel.Add(insertBays("A5"));
            }
            d = false;
        }

        static BayModel insertBays(string bay)
        {
            BayModel bm = new BayModel();
            bm.Bay = bay;
            bm.available = true;
            return bm;
        }
    }
}
