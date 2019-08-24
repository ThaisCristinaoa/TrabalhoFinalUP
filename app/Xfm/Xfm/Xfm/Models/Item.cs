using System;
using System.Collections.Generic;
using System.Text;

namespace Xfm.Models
{
   public sealed class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string pictureUrl { get; set; }

        public static Item Create(string title, string description, string pictureUrl)
            => new Item
            {
                Title = title,
                Description = description,
                pictureUrl = pictureUrl
            };
    }
}
