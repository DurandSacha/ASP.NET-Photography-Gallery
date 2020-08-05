using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Photography_Gallery.Models
{
    public class Photography
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Path { get; set; }
    }

    public class Photographies
    {

        public List<Photography> GetAllPhotographies()
        {
            return new List<Photography>
            {
                new Photography { id = 1, Nom = "Photo1", Path = "../"},
                new Photography { id = 30, Nom = "Photo2", Path = "../"},
                new Photography { id = 33, Nom = "Photo3", Path  ="../"},
                new Photography { id = 1, Nom = "Photo4", Path = "../"}
            };
        }
    }
}