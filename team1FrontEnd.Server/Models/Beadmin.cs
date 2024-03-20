﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class Beadmin
{
    public int Id { get; set; }

    public string Account { get; set; }

    public string EncryptedPassword { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public DateTime RegistrationDate { get; set; }

    public bool ActiveStatus { get; set; }

    public bool IsEmailConfirmed { get; set; }

    public string VerificationCode { get; set; }

    public virtual ICollection<AdminRole> AdminRoles { get; set; } = new List<AdminRole>();

    public virtual ICollection<CarOrder> CarOrders { get; set; } = new List<CarOrder>();

    public virtual ICollection<HotelOrder> HotelOrders { get; set; } = new List<HotelOrder>();
}