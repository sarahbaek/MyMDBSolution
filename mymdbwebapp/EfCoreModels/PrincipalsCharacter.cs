﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mymdbwebapp.EfCoreModels
{
    public partial class PrincipalsCharacter
    {
        public int CharId { get; set; }
        public int PrincipalId { get; set; }
        public string Character { get; set; }

        public virtual TitlePrincipal Principal { get; set; }
    }
}