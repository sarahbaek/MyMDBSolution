﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mymdbwebapp.EfCoreModels
{
    public partial class TitleAliasesType
    {
        public int AliasId { get; set; }
        public int AliasTypeId { get; set; }

        public virtual TitleAlias Alias { get; set; }
        public virtual AliasType AliasType { get; set; }
    }
}