using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTest.Models
{
    public class Reservation
    {
        //attrbiutes
        // no need private at the moment
        public int ReservationID { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}
