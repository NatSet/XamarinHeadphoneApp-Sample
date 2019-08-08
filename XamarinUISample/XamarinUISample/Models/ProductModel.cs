using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUISample.Models
{
    class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Path { get; set;}
        public string Color { get; set; }
        public string BackgroundColor { get; set; }
        public string Battery { get; set; }
        public string Connection { get; set; }
        public string Description { get; set; }
    }
}
