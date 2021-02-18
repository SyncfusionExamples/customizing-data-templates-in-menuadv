using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAdv_MVVM
{
    public class MenuBarModel : NotificationObject
    {
        private string header;
        private string gestureText;
       
        public MenuBarModel()
        {
            MenuItems = new ObservableCollection<MenuBarModel>();
        }

        public ObservableCollection<MenuBarModel> MenuItems { get; set; }


        public string Header { get { return header; } set { header = value; RaisePropertyChanged(nameof(Header)); } }

        public string GestureText { get { return gestureText; } set { gestureText = value; RaisePropertyChanged(nameof(GestureText)); } }
    }

}
