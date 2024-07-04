﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.App.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAssigned { get; set; }
        public int? MemberId { get; set; }
    }
}