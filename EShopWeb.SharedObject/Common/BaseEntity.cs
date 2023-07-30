﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopWeb.SharedObject.Common
{
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public Confirm IsDeleted { get; set; }

        public BaseEntity SetCreateInfo(string user, DateTime date)
        {
            this.CreatedAt = date;
            this.CreatedBy = user;
            return this;
        }

        public BaseEntity SetUpdateInfo(string user, DateTime date)
        {
            this.LastUpdatedBy = user;
            this.LastUpdatedAt = date;
            return this;
        }

        public BaseEntity MarkAsDelete(string user, DateTime date)
        {
            this.IsDeleted = Confirm.Yes;
            this.LastUpdatedBy = user;
            this.LastUpdatedAt = date;
            return this;
        }
    }
}
