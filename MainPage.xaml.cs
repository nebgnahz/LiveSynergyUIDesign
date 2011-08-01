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
using Microsoft.Phone.Shell;
using Microsoft.Phone.Controls;


namespace LiveSynergyUIDesign
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            LoadDevices();
            ListPublicThing.SelectionChanged += OnPublicDeviceSelectedChanged;

       }

        public static System.Collections.Generic.IEnumerable<PublicGrouping<string, Device>> deviceByLocation;
        public static System.Collections.Generic.IEnumerable<PublicGrouping<string, Device>> deviceByName;

        private void LoadDevices()
        {
            List<Device> PublicThings = new List<Device>
            {
                new Device(){ DeviceName="Television", DeviceLocation="\\msra\\floor\\12\\focus_room" },
                new Device(){ DeviceName="Light", DeviceLocation="\\msra\\floor\\12\\focus_room"},
                new Device(){ DeviceName="Light2", DeviceLocation="\\msra\\floor\\12\\focus_room"},
                new Device(){ DeviceName="Light3", DeviceLocation="\\msra\\floor\\12\\focus_room"},
                new Device(){ DeviceName="Computer", DeviceLocation="\\msra\\floor\\12\\fred_cubical"},
                new Device(){ DeviceName="Xbox 360", DeviceLocation="\\msra\\floor\\12\\lobby"},
                new Device(){ DeviceName="Oscilloscope", DeviceLocation="\\msra\\floor\\12\\fred_cubical"}
            };

            deviceByLocation = from device in PublicThings
                                   group device by device.DeviceLocation into c
                                   orderby c.Key
                                   select new PublicGrouping<string, Device>(c); 
            
            deviceByName = from device in PublicThings
                                   group device by device.DeviceNameFirstLetter into c
                                   orderby c.Key
                                   select new PublicGrouping<string, Device>(c);

            ListPublicThing.ItemsSource = deviceByName;

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
        {
            
        }

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
        void OnClickSignUp(object sender, EventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/SignUpPage.xaml", UriKind.Relative));
        }

        void OnMenuClicked(object sender, RoutedEventArgs args)
        {
            string command = (string)(((MenuItem)sender).Tag);
            switch (command)
            {
                case ("VIEW"): break;
                case ("REMOVE"): break;
                default: break;
            }
        }
        /*
            ListHeaderTemplate="{StaticResource DeviceListHeader}"
            GroupHeaderTemplate="{StaticResource DeviceGroupHeader}"
            GroupItemTemplate="{StaticResource groupItemHeader}"
            ItemTemplate="{StaticResource DeviceItemTemplate}"
         */
        void OnClickSortByLocation(object sender, EventArgs args)
        {
            ListPublicThing.GroupHeaderTemplate = this.Resources["DeviceGroupHeaderLocation"] as DataTemplate;
            ListPublicThing.ItemsSource = deviceByLocation;
            ListPublicThing.GroupItemTemplate = this.Resources["groupItemHeaderLocation"] as DataTemplate;            
        }
        void OnClickSortByName(object sender, EventArgs args)
        {
            ListPublicThing.GroupHeaderTemplate = this.Resources["DeviceGroupHeaderNameFirst"] as DataTemplate; 
            ListPublicThing.ItemsSource = deviceByName;
            ListPublicThing.GroupItemTemplate = this.Resources["groupItemHeaderNameFirst"] as DataTemplate;
        }
        void OnPublicDeviceSelectedChanged(object sender, EventArgs args)
        {
            Device device = ListPublicThing.SelectedItem as Device;
            if (device != null)
            {
                NavigationService.Navigate(new Uri("/ViewObjectPage.xaml?Name=" + device.DeviceName, UriKind.Relative));
            }
        }



        void OnTapFlowChart(object sender, EventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/Program.xaml", UriKind.Relative));
        }


        void OnTapEvent(object sender, EventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/LongListSelection.xaml", UriKind.Relative));
        }

        void OnTapCommand1(object sender, EventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/LongListSelection.xaml", UriKind.Relative));
        }

        void OnTapCommand2(object sender, EventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/LongListSelection.xaml", UriKind.Relative));
        }



        private double PreviousOpacity { get; set; }
        void Appbar_StateChanged(object sender, ApplicationBarStateChangedEventArgs args)
        {
            var opacity = this.ApplicationBar.Opacity;
            this.ApplicationBar.Opacity = args.IsMenuVisible ? 1 : PreviousOpacity;
            this.PreviousOpacity = opacity;
        }

    }

}