﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mymdbwebapp.EfCoreModels
{
    public partial class Genre
    {
        public Genre()
        {
            TitlesGenres = new HashSet<TitlesGenre>();
        }

        public int GenreId { get; set; }
        public string Genre1 { get; set; }

        public virtual ICollection<TitlesGenre> TitlesGenres { get; set; }
    }
}