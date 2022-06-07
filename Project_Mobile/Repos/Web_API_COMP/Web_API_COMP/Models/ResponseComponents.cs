using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_COMP.Entitnes;

namespace Web_API_COMP.Models
{
    public class ResponseComponents
    {
        public ResponseComponents(Components components)
        {
            id = components.id;
            idC = components.Category.NameC;
            idM = components.Manufacturer.NameM;
            Model = components.Model;
            Quantity = components.Quantity;
            Price_R = components.Price_R;
            Image = components.ComponentsImage.ToList().FirstOrDefault()?.Image;
        }

        public int id { get; set; }
        public string idC { get; set; }
        public string idM { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Price_R { get; set; }
        public byte[] Image { get; set; }
    }
}