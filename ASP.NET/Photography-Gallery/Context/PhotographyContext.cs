using Photography_Gallery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Photography_Gallery.Context
{
    public class PhotographyContext : DbContext
        //: base("name=BDD_PhotoGallery")
    {
        public DbSet<Photography> Photographies { get; set; }
    }
}