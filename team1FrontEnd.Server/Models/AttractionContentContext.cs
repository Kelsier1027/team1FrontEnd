﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace myapi.Models;

public partial class AttractionContentContext
{
    public int Id { get; set; }

    public int AttractionId { get; set; }

    public string SubTitle { get; set; }

    public string TagContent { get; set; }

    public string Highlight { get; set; }

    public string ActivityDescription { get; set; }

    public string Qa { get; set; }

    public virtual Attraction Attraction { get; set; }
}