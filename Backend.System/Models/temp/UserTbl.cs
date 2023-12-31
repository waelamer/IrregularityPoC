﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DealStoreweb.Backend.Models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            CustomerTbls = new HashSet<CustomerTbl>();
            ProviderTbls = new HashSet<ProviderTbl>();
            RequestTbls = new HashSet<RequestTbl>();
            ServiceTbls = new HashSet<ServiceTbl>();
        }

        public Guid UserRef { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public bool IsNotifyEmail { get; set; }
        public bool IsNotifySms { get; set; }
        public bool IsServiceProvider { get; set; }
        public DateTime? CreatedDatetimeOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDatetimeOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CustomerTbl> CustomerTbls { get; set; }
        public virtual ICollection<ProviderTbl> ProviderTbls { get; set; }
        public virtual ICollection<RequestTbl> RequestTbls { get; set; }
        public virtual ICollection<ServiceTbl> ServiceTbls { get; set; }
    }
}