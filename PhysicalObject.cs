using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Threading;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace LiveSynergyUIDesign
{
    public class PhysicalObject: System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _objectName;

        public string ObjectName
        {
            set
            {
                if (_objectName != value)
                {
                    _objectName = value;
                    OnPropertyChanged("ObjectName");
                }
            }
            get
            {
                return _objectName;
            }
        }

        protected virtual void OnPropertyChanged(string propChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propChanged));
        }
    }



    public class ListPhysicalObject : System.ComponentModel.INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        string objectsAttr;
        ObservableCollection<PhysicalObject> objects = new ObservableCollection<PhysicalObject>();

        public string ObjectsAttr
        {
            set
            {
                if (objectsAttr != value)
                {
                    objectsAttr = value;
                    OnPropertyChanged("ObjectsAttr");
                }
            }
            get
            {
                return objectsAttr;
            }
        }

        public ObservableCollection<PhysicalObject> Objects
        {
            set
            {
                if (objects != value)
                {
                    objects = value;
                    OnPropertyChanged("Object");
                }
            }
            get
            {
                return objects;
            }
        }

        protected virtual void OnPropertyChanged(string propChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propChanged));
        }
    }

    public class PhysicalObjectPresenter : System.ComponentModel.INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        ListPhysicalObject listPhyObject;
        string objectsAttr;
        ObservableCollection<PhysicalObject> objects = new ObservableCollection<PhysicalObject>();

        public PhysicalObjectPresenter()
        {
/*
            Uri uri = new Uri("http://www.charlespetzold.com/Students/students.xml"); // , UriKind.Relative);
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += OnDownloadStringCompleted;
            webClient.DownloadStringAsync(uri);
        }

        void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs args)
        {
            StringReader reader = new StringReader(args.Result);
            XmlSerializer xml = new XmlSerializer(typeof(ListPhysicalObject));
            ListPhyObject = xml.Deserialize(reader) as ListPhysicalObject;
*/
       }

        public ListPhysicalObject ListPhyObject
        {
            protected set
            {
                if (listPhyObject != value)
                {
                    listPhyObject = value;
                    OnPropertyChanged("ListPhysicalObject");
                }
            }
            get
            {
                return listPhyObject;
            }
        }


        protected virtual void OnPropertyChanged(string propChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propChanged));
        }

    }
}
