﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LambdaLinq.ViewModels
{
    public class SearchViewModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public decimal lowPrice { get; set; } = 0;
        public decimal highPrice { get; set; } = 0;
    }
}