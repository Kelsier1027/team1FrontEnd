﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace myapi.Models;

public partial class MemberProfile
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public string Email { get; set; }

    public string ProfileImage { get; set; }

    public string Country { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? Gender { get; set; }

    public string PhoneNumber { get; set; }

    public virtual Member Member { get; set; }
}