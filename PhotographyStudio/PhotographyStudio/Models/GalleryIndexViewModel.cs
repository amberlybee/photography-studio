using System.Collections.Generic;

namespace PhotographyStudio.Models
{
    public class GalleryIndexViewModel
    {
        public GalleryIndexViewModel()
        {
            SeniorsPhotos = new List<string>();
            FamilyPhotos = new List<string>();
            ChildrenPhotos = new List<string>();
        }

        public ICollection<string> SeniorsPhotos { get; set; }
        public ICollection<string> FamilyPhotos { get; set; }
        public ICollection<string> ChildrenPhotos { get; set; }

        public string SeniorsTitle { get; set; }
        public string FamilyTitle { get; set; }
        public string ChildrenTitle { get; set; }

    }
}
