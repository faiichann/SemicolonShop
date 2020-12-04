using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Models
{
        public partial class Chart
        {
            public string Month { get; set; }
            public int Qty { get; set; }
        }
}
