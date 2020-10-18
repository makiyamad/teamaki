using System;

namespace TeaMaki.Ui.Components.Menu
{
    public class ProductResponse
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

    }
}