﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace myapi.Models;

public partial class CarTransmission
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<CarModel> CarModels { get; set; } = new List<CarModel>();
}