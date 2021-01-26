using System.Collections.Generic;

namespace demo10.Data
{
    public static class NavData
    {
        public static List<NavItem> Items = new List<NavItem>
        {
            new NavItem("Dashboard", "/Index", "dashboard"),
            new NavItem("DirectEvent", "/DirectEvent", "flash_on"),
            new NavItem("GridPanel", "/GridPanel", "grid_on"),
            new NavItem("Form", "/layoutform", "loyalty"),
            new NavItem("HboxLayout", "/HboxLayout", "grid_on")
            
        };
    }

    public class NavItem
    {
        public NavItem(string name, string path, string iconCls)
        {
            Name = name;
            Path = path;
            IconCls = iconCls;
           
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string IconCls { get; set; }
       
    }
}
