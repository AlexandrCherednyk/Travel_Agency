using DAL.EF;
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
    public class ReservationRepository// : IRepository<Reservation>
    {
        private DatabaseContext context;
        public ReservationRepository(DatabaseContext context)
        {
            this.context = context;
        }
        
    }
}
