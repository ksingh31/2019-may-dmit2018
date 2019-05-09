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
    [DataObject]
    class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Artist> Artist_List()
        {
            using (var context = new ChinookSystemContext())
            {
                // the entity framework returns an IEnumberable or
                // IQueryable DbSet
                // Since this method expects to return a List<T>
                // the DbSet needs to be case to that datatype
                // To case the DbSet to List<T> use .ToList();
                return context.Artists.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Artist Artist_Get(int artistid)
        {
            using (var context = new ChinookSystemContext())
            {
                return context.Artists.Find(artistid);
            }
        }
    }
}
