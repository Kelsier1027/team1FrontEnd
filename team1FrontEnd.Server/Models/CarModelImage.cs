﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class CarModelImage
{
    public int Id { get; set; }

    public string FileName { get; set; }

    public int CarModelId { get; set; }

    public virtual CarModel CarModel { get; set; }
}