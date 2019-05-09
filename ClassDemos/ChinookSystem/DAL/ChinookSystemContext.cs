using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

# region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    internal class ChinookSystemContext:DbContext
    {
        //constructor to pass on the connections string name to DbContext
        // :base("ChinookDB") passes ChinookDB connection string to DbContext
        public ChinookSystemContext():base("ChinookDB")
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> GenreS { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
    }
}
