﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange_Things.Models
{
    public class CompanyAddedViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescription { get; set; }
        public int NumberOfCharsInOwnerName { get; set; }
        public bool IsHidden { get; set; }
    }
}
