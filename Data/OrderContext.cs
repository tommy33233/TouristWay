﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class TouristAppContext : DbContext
    {
        public DbSet<Tourist> Tourists { get; set; }
    }
}
