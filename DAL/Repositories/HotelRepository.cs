using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class HotelRepository : IRepository<Hotel>
    {
        private DatabaseContext Context;

        public HotelRepository(DatabaseContext context)
        {
            this.Context = context;
        }

        public void Create(Hotel item)
        {
            Context.Hotels.Add(item);
        }

        public Hotel GetByGuId(Guid id)
        {
            return Context.Hotels
                .Include(h => h.Lodgings)
                    .ThenInclude(l => l.Reservations)
                        .Where(h => h.Id == id)
                        .FirstOrDefault();
        }

        public IEnumerable<Hotel> GetAll()
        {
            return Context.Hotels
                .Include(h => h.Lodgings)
                    .ThenInclude(l => l.Reservations);
        }

        public void Update(Hotel entity)
        {
            //Context.Entry(entity).State = EntityState.Modified;

            //var hotel = Context.Hotels.FirstOrDefault(h => h.Id == entity.Id);

            Context.Hotels.Update(entity);
        }

        public void DeleteByGuid(Guid id)
        {
            Hotel hotel = Context.Hotels
               .Where(h => h.Id == id)
               .FirstOrDefault();

            if (hotel != null)
                Context.Hotels.Remove(hotel);
        }
    }
}
