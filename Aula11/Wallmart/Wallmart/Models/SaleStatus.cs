﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallmart.Models
{
    public enum SaleStatus : int
    {
        PENDING = 0,
        BILLED = 1,
        CANCELED = 2
    }
}
