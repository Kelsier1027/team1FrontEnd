﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace team1FrontEnd.Server.Models;

public partial class Comment
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int Rating { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public DateTime CommentDateTime { get; set; }

    public int ServiceCategoryId { get; set; }

    public int ItemId { get; set; }

    public virtual ICollection<CommentImage> CommentImages { get; set; } = new List<CommentImage>();

    public virtual Member Member { get; set; }

    public virtual ServiceCategory ServiceCategory { get; set; }
}