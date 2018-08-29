using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotographyStudio.Models
{
    public class GallerySession
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        [ForeignKey("GalleryId")]
        public virtual Gallery Gallery { get; set; }
    }
}
