﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DealStoreweb.Backend.Models
{
    public partial class RequestTbl
    {
        public int Id { get; set; }
        public int ServiceID { get; set; }
        public Guid UserRef { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDatetimeOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDatetimeOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ServiceTbl Service { get; set; }
        public virtual UserTbl UserRefNavigation { get; set; }
    }
}