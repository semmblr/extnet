using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Ext.Net;
using Ext.Net.Core;

namespace demo10.Pages
{
    public class GridPanelModel : PageModel
    {
        

        public List<object> GridData { get; set; }

        public void OnGet()
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:tt");

            this.GridData ??= new List<object>
            {
                new object[] { "3m Co", 71.72, 0.02, 0.03, now },
                new object[] { "Alcoa Inc", 29.01, 0.42, 1.47, now },
                new object[] { "Altria Group Inc", 83.81, 0.28, 0.34, now },
               
            
            };
        }
    }
}