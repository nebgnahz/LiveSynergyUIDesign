using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace LiveSynergyUIDesign
{
    public partial class AddNewThing : PhoneApplicationPage
    {
        public AddNewThing()
        {
            InitializeComponent();


            List<string> cities = new List<string>();
            cities.Add("London");
            cities.Add("Seattle");
            cities.Add("Tokyo");
            cities.Add("Nairobi");
            cities.Add("Lisbon");
            cities.Add("New York");
            cities.Add("Paris");
            cities.Add("San Francisco");
            AutoComplete.ItemsSource = cities;

        }

        void OnClickCheckNewObject(object sender, EventArgs args)
        {

        }
        void OnClickCancelNewObject(object sender, EventArgs args)
        {

        }

    }

}