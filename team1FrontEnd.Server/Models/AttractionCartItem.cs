﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class AttractionCartItem
{
    public int Id { get; set; }

    public int CartId { get; set; }

    public int Items { get; set; }

    public int Quantity { get; set; }

    public virtual AttractionCart Cart { get; set; }

    public virtual AttractionTicket ItemsNavigation { get; set; }
}