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
    public partial class MainPage : PhoneApplicationPage
    {

        List<PhysicalObject> PublicThings = new List<PhysicalObject>
        {
            new PhysicalObject(){ ObjectName="Television" },
            new PhysicalObject(){ ObjectName="Light" },
            new PhysicalObject(){ ObjectName="Computer"},
            new PhysicalObject(){ ObjectName="Xbox 360"},
            new PhysicalObject(){ ObjectName="Oscilloscope"}
        };
        
        List<PhysicalObject> PrivateThings = new List<PhysicalObject>
        {
            new PhysicalObject(){ ObjectName="My PC" },
            new PhysicalObject(){ ObjectName="My light" },
            new PhysicalObject(){ ObjectName="my laptop"},
            new PhysicalObject(){ ObjectName="my elevator"},
            new PhysicalObject(){ ObjectName="my cubicle"}
        };
        

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            PublicThingList.ItemsSource = PublicThings;
            PrivateThingList.ItemsSource = PrivateThings;
        }

        void FillItUp(ItemsControl itemsControl, string[] ItemsCollection)
        {
            foreach (string item in ItemsCollection)
                itemsControl.Items.Add(new FontFamily(item));
        }


        void OnAppbarAddClick(object sender, EventArgs args) 
        {
            this.NavigationService.Navigate(new Uri("/AddNewThing.xaml", UriKind.Relative));
        }
        void OnAppbarDeleteClick(object sender, EventArgs args)
        { }

        void OnAppbarNextClick(object sender, EventArgs args)
        { }
        
        void OnAppbarBackClick(object sender, EventArgs args)
        { }
        
        void OnClickProgramThis(object sender, EventArgs args)
        {

        }
        void OnClickViewProgram(object sender, EventArgs args)
        {

        }
        void OnListBoxSelectionChanged(object sender, EventArgs args)
        {

        }
    }
}