﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PhotographyStudio.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Path { get; set; }
        public string Alt { get; set; }

        //public int GalleryId { get; set; }

        //[ForeignKey("GalleryId")]
        public virtual Gallery Gallery { get; set; }
    }
}