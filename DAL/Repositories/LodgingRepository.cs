﻿using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LodgingRepository //: IRepository<Lodging>
    {
        private DatabaseContext context;
        public LodgingRepository(DatabaseContext context)
        {
            this.context = context;
        }
        
    }
}
