﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.Core.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Item> Items { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
