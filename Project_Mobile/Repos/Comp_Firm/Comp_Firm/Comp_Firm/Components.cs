using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Comp_Firm
{
    class Components
    {

        public int id { get; set; }
        public string idC { get; set; }
        public string idM { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public float Price_R { get; set; }
        public string Image { get; set; }

        public ImageSource Photo
        {
            get
            {
                return ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(Image)));
            }
        }
    }
}
