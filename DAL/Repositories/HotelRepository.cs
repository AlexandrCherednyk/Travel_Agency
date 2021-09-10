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
    public class HotelRepository : IRepository<Hotel>
    {
        private DatabaseContext context;

        public HotelRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Create(Hotel item)
        {
            context.Hotels.Add(item);
        }

        public Hotel GetByDbId(int id)
        {
            return context.Hotels
                .Include(h => h.Lodgings)
                    .ThenInclude(l => l.Reservations)
                        .Where(h => h.DbId == id)
                        .FirstOrDefault();
        }

        public Hotel GetByGuId(Guid id)
        {
            return context.Hotels
                .Include(h => h.Lodgings)
                    .ThenInclude(l => l.Reservations)
                        .Where(h => h.Id == id)
                        .FirstOrDefault();
        }

        public IEnumerable<Hotel> GetAll()
        {
            return context.Hotels
                .Include(h => h.Lodgings)
                    .ThenInclude(l => l.Reservations);
        }

        public void Update(Hotel entity)
        {
            context.Hotels.Update(entity);
        }

        public void Update(Hotel entity, Guid id)
        {
            Hotel hotel = context.Hotels
                .First(h => h.Id == id);

            if (hotel != null)
            {
                hotel.Name = entity.Name;
                hotel.Country = entity.Country;
                hotel.StarRating = entity.StarRating;
                hotel.Lodgings = entity.Lodgings;
                hotel.MealsTypes = entity.MealsTypes;
                hotel.PathToImage = entity.PathToImage;

                context.Hotels.Update(hotel);
            }
        }

        public void DeleteByDbId(int id)
        {
            Hotel hotel = context.Hotels.Find(id);
            if (hotel != null)
                context.Hotels.Remove(hotel);
        }

        public void DeleteByGuid(Guid id)
        {
            Hotel hotel = context.Hotels
               .Where(h => h.Id == id)
               .FirstOrDefault();

            if (hotel != null)
                context.Hotels.Remove(hotel);
        }
    }
}
