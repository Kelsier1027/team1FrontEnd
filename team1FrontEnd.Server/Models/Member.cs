﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Account { get; set; }

    public string EncryptedPassword { get; set; }

    public DateTime RegistrationDate { get; set; }

    public bool ActiveStatus { get; set; }

    public string Salt { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public bool? IsEmailVerified { get; set; }

    public virtual ICollection<AttractionOrder> AttractionOrders { get; set; } = new List<AttractionOrder>();

    public virtual ICollection<CarOrder> CarOrders { get; set; } = new List<CarOrder>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<HotelOrder> HotelOrders { get; set; } = new List<HotelOrder>();

    public virtual ICollection<MemberActivityRecord> MemberActivityRecords { get; set; } = new List<MemberActivityRecord>();

    public virtual ICollection<MemberPersonalInfo> MemberPersonalInfos { get; set; } = new List<MemberPersonalInfo>();

    public virtual ICollection<MemberProfile> MemberProfiles { get; set; } = new List<MemberProfile>();

    public virtual ICollection<PackageOrder> PackageOrders { get; set; } = new List<PackageOrder>();

    public virtual ICollection<PointTransction> PointTransctions { get; set; } = new List<PointTransction>();
}