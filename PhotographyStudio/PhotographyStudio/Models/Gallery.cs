using System.Collections;
using System.Collections.Generic;

namespace PhotographyStudio.Models
{
    public class Gallery
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}