using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext context;
        private HotelRepository hotelRepository;
        //private LodgingRepository LodgingRepository;
        //private ReservationRepository reservationRepository;

        public UnitOfWork()
        {
            context = new DatabaseContext();
        }

        public IRepository<Hotel> HotelRepository
        {
            get
            {
                if (hotelRepository == null)
                    hotelRepository = new HotelRepository(context);
                return hotelRepository;
            }
        }

        //public IRepository<Lodging> Lodgings => throw new NotImplementedException();

        //public IRepository<Reservation> Reservations => throw new NotImplementedException();

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
