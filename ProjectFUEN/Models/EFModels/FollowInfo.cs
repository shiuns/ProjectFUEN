﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProjectFUEN.Models.EFModels
{
    public partial class FollowInfo
    {
        public int Follower { get; set; }
        public int Following { get; set; }
        public DateTime FollowTime { get; set; }

        public virtual Member FollowerNavigation { get; set; }
        public virtual Member FollowingNavigation { get; set; }
    }
}