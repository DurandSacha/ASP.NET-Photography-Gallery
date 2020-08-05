using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Photography_Gallery.Models;

namespace Photography_Gallery.Context
{
    public class BddContext : DbContext
    {
        public DbSet<Photography> Photographies { get; set; }
        public DbSet<User> User { get; set; }
    }
}