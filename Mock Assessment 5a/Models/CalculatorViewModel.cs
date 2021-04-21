using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock_Assessment_5a.Models
{
    public class CalculatorViewModel
    {
        [ViewData]
        public int Num1 { get; set; }

        [ViewData]
        public int Num2 { get; set; }

        [ViewData]
        public int Result { get; set; }

        [ViewData]
        public Operations Operation { get; set; }
    }
}
