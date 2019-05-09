﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Data.Entities
{
    // default class permission is private
    //annotation to link this class to the sql table
    [Table("Artists")]
    public class Artist
    {
        private string _Name;
        // [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] Identiy ias default so we dont need to enter DatabaseGenerated.....
        [Key]
        public int ArtistId { get; set; }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }
        }

        //navigational properties
        public virtual ICollection<Albums> Albums { get; set; }
    }
}
