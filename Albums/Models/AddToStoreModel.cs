using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Albums.Models
{
    public class AddToStoreModel
    {
        public int selectedAlbum { get; set; }
        public int selectedStore { get; set; }
        public List<Album> albums { get; set; }
        public AddToStoreModel()
        {
            albums = new List<Album>();
        }
    }
}