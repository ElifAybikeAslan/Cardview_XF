using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Cardview_XF.Models
{
    public class CardviewModel
    {
        public string Name { get; set; }
        public string StatusImage { get; set; }
        public DateTime Time { get; set; }
        public Color AlertColor { get; set; }
    }
}
