﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVCcoreProject.Models
{
    public class Product
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public  DateTime AddDate { get; set; }

    }
}
