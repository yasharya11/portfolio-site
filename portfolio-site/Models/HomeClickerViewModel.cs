using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Core;
using Portfolio.Data;

namespace portfolio_site.Models
{
    public class HomeClickerViewModel : PageModel
    {
        private IClickData clickData;

        public IEnumerable<Click> Clicks{ get; set; }

        public HomeClickerViewModel(IClickData clickData)
        {
            this.clickData = clickData;
            Clicks = clickData.GetAll();
        }
    }
}
