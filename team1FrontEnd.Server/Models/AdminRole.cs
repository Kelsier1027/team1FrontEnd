﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class AdminRole
{
    public int Id { get; set; }

    public int AdminId { get; set; }

    public int RoleId { get; set; }

    public virtual Beadmin Admin { get; set; }

    public virtual Role Role { get; set; }
}