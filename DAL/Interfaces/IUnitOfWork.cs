using DAL.Entities;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Hotel> HotelRepository { get; }
        //IRepository<Lodging> Lodgings { get; }
        //IRepository<Reservation> Reservations { get; }
        void Save();
    }
}
