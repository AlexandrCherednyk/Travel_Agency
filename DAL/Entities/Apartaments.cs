using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public enum ApartamentType
    {
        A,
        B,
        C,
        Luxe
    }

    public class Apartaments : Lodging
    {
        public int RoomsNumber { get; set; }
        public ApartamentType Type { get; set; }

        public Apartaments() { }
    }
}
