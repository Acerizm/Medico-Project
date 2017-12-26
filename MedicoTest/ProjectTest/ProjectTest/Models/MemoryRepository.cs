using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTest.Models
{
    // not a persistent storage for this MedicoTest
    public class MemoryRepository : IRepository // using the interface;
    {
        // it is a must to use the interface when an interface is inherited

        //attributes
        private Dictionary<int, Reservation> items;
        // key-value types 
        // same like python dictionaries

        // default-constructor
        public MemoryRepository()
        {
            //instiantate the dictionary
            items = new Dictionary<int, Reservation>();
            new List<Reservation>
            {
                new Reservation {ClientName = "Alice", Location = "Board Room"},
                new Reservation {ClientName = "Bob" , Location = "Lecture Hall"},
                new Reservation {ClientName = "Joe", Location = "Meeting Room 1"}
            }.ForEach(r => AddReservation(r)); // a lambda expression is used here;
        }

        //Methods/Operations
        // [Read]
        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;
        // if true return the item specified by the id
        // else return null;

        // [Read]
        public IEnumerable<Reservation> Reservations => items.Values;
        // returns the all the items enumerically.

        // [Create]
        public Reservation AddReservation(Reservation reservation)
        {
            // base-case when there is no reservation yet made;
            if (reservation.ReservationID == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                // check if the dictionary items contains a key-value pair that
                // has existed.
                // use a pre-defined method made by C# called ContainsKey();
                // 0(n) time-complexity;
                reservation.ReservationID = key;
            }
            items[reservation.ReservationID] = reservation;
            return reservation;
        }

        // [Delete]

        public void DeleteReservation(int id) => items.Remove(id);
        // removes the value with the specified key;

        // [Update]
        public Reservation UpdateReservation(Reservation reservation)
            => AddReservation(reservation);
    } 
}
