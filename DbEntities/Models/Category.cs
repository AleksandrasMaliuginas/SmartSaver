﻿using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Category
    {
        public Category()
        {
            Transaction = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public decimal? DedicatedAmount { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
