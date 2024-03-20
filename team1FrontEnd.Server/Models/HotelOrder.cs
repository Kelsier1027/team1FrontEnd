﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class HotelOrder
{
    public int Id { get; set; }

    public string OrderSn { get; set; }

    public int NumberOfPeople { get; set; }

    public bool Breakfast { get; set; }

    public int HotelOrderStatusId { get; set; }

    public string Phone { get; set; }

    public string CreditCard { get; set; }

    public int MemberId { get; set; }

    public int Price { get; set; }

    public DateTime Checkin { get; set; }

    public DateTime Checkout { get; set; }

    public int? HotelOrderCancelReasonId { get; set; }

    public int AdminId { get; set; }

    public virtual Beadmin Admin { get; set; }

    public virtual HotelOrderCancelReason HotelOrderCancelReason { get; set; }

    public virtual ICollection<HotelOrderItem> HotelOrderItems { get; set; } = new List<HotelOrderItem>();

    public virtual HotelOrderStatus HotelOrderStatus { get; set; }

    public virtual Member Member { get; set; }
}