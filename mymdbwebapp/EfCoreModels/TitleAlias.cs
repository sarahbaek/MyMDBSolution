﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mymdbwebapp.EfCoreModels
{
    public partial class TitleAlias
    {
        public TitleAlias()
        {
            TitleAliasesTypes = new HashSet<TitleAliasesType>();
        }

        public int AliasId { get; set; }
        public string Tconst { get; set; }
        public string Title { get; set; }
        public string Region { get; set; }
        public string Language { get; set; }
        public bool IsOriginalTitle { get; set; }
        public string Attributes { get; set; }

        public virtual TitleBasic TconstNavigation { get; set; }
        public virtual ICollection<TitleAliasesType> TitleAliasesTypes { get; set; }
    }
}