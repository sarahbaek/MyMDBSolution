﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mymdbwebapp.EfCoreModels
{
    public partial class TitlesDirector
    {
        public string Tconst { get; set; }
        public string DirectorNconst { get; set; }

        public virtual NameBasic DirectorNconstNavigation { get; set; }
        public virtual TitleBasic TconstNavigation { get; set; }
    }
}