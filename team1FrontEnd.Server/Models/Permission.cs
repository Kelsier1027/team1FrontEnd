﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string ChineseName { get; set; }

    public string NameInSystem { get; set; }

    public string Description { get; set; }

    public string Category { get; set; }

    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}