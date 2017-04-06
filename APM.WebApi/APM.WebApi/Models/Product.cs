﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.WebApi.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}