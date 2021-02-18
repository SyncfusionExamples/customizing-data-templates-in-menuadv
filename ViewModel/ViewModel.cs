using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAdv_MVVM
{
    class ViewModel
    {
        public ObservableCollection<MenuBarModel> MenuModel { get; set; } = new ObservableCollection<MenuBarModel>();
        public ObservableCollection<MenuBarModel> Menu { get; set; } = new ObservableCollection<MenuBarModel>();

        public ObservableCollection<MenuBarModel> MainMenuItem { get; set; } = new ObservableCollection<MenuBarModel>();

        public ObservableCollection<MenuBarModel> SubMenuItem { get; set; } = new ObservableCollection<MenuBarModel>();


        public ViewModel()
        {
            Menu = PopulateMenu();
        }

        private ObservableCollection<MenuBarModel> PopulateMenu()
        {

            MenuBarModel product = new MenuBarModel() { Header = "Products" };

            MainMenuItem = PopulateSubSubItems(product);

            MenuModel.Add(product);

            return MainMenuItem;
        }
        

        private ObservableCollection<MenuBarModel> PopulateSubSubItems(MenuBarModel item)
        {

            MenuBarModel menu3 = new MenuBarModel() { Header = "Tools" };
            MenuBarModel menu4= new MenuBarModel() { Header = "Chart" };
            MenuBarModel menu5 = new MenuBarModel() { Header = "Grid" };
            MenuBarModel menu6 = new MenuBarModel() { Header = "Diagram" };
            MenuBarModel menu7 = new MenuBarModel() { Header = "Gauge" };
            MenuBarModel menu8 = new MenuBarModel() { Header = "Schedule" };
            MenuBarModel menu9 = new MenuBarModel() { Header = "Edit" };

            MenuBarModel item1 = new MenuBarModel() { Header = "WPF" };
            MenuBarModel item2 = new MenuBarModel() { Header = "SilverLight" };
           

            MenuBarModel menu = new MenuBarModel() { Header = "Business Intelligence" };
            MenuBarModel menu1 = new MenuBarModel() { Header = "User Interface" };
            MenuBarModel menu2 = new MenuBarModel() { Header = "Reporting" };
            menu1.MenuItems.Add(item1);
            menu1.MenuItems.Add(item2);

            item1.MenuItems.Add(menu3);
            item1.MenuItems.Add(menu4);
            item1.MenuItems.Add(menu5);
            item1.MenuItems.Add(menu6);
            item1.MenuItems.Add(menu7);
            item1.MenuItems.Add(menu8);
            item1.MenuItems.Add(menu9);


            item.MenuItems.Add(menu);
            item.MenuItems.Add(menu1);
            item.MenuItems.Add(menu2);

            SubMenuItem.Add(item);
            return SubMenuItem;
        }
    }
}
