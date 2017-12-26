using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTest.Models
{
    public interface IRepository
    {
        // this will be the interface for the model repository
        // no databased used.
        //attributes
        IEnumerable<Reservation> Reservations { get; } 
        // Genereic of type reservation.
        // it is an enumerator of type Reservation.
        Reservation this[int id] { get; }
        // when the interface is instiantated;

        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);
        // delete method just make it a void method that returns nothing;
    }
}





