using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.DAL;
using ChinookSystem.Data.Entities;
using System.ComponentModel; // this is for ods
#endregion

namespace ChinookSystem.BLL
{
    [DataObject] // needed to expose this
    class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_List()
        {
            using (var context = new ChinookSystemContext())
            {
                // the entity framework returns an IEnumberable or
                // IQueryable DbSet
                // Since this method expects to return a List<T>
                // the DbSet needs to be case to that datatype
                // To case the DbSet to List<T> use .ToList();
                return context.Albums.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Album Album_Get(int albumid)
        {
            using (var context = new ChinookSystemContext())
            {
                return context.Albums.Find(albumid);
            }
        }
    }
}
