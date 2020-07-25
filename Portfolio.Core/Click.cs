using System;
using System.Collections.Generic;
using System.Text;


namespace Portfolio.Core
{
    public class Click
    {
        public DateTime ClickedDt { get; set; }
        public string Id { get; set; }
        public EditedStatus Edited { get; set; }
    }
}
