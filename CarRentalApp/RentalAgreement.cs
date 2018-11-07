using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{    
    enum RentalLocations
    {
        Seattle,
        Dallas,
        Denver,
        WashingtonDC
    }

    class RentalAgreement
    {
        #region Properties
        public DateTime DateOfPickup { get; set; }
        public RentalLocations LocationToPickup { get; set; }
        public DateTime DateOfReturn { get; set; }
        public RentalLocations LocationToDropOff { get; set; }
        public string Destination { get; set; }
        public string Drivers { get; set; }


        #endregion

        private static List<RentalAgreement> reservations = new List<RentalAgreement>();

        public static RentalAgreement Reservation(DateTime dateOfPickup, RentalLocations locationToPickup, DateTime dateOfReturn, RentalLocations locationToDropOff, string destination, string drivers)
        {
            var reservation = new RentalAgreement
            {
                DateOfPickup = dateOfPickup,
                LocationToPickup = locationToPickup,
                DateOfReturn = dateOfReturn,
                LocationToDropOff = locationToDropOff,
                Destination = destination,
                Drivers = drivers,
            };

            reservations.Add(reservation);
            return reservation;
        }
        public static IEnumerable<RentalAgreement> GetAllReservations()
        {
            return reservations;
        }
    }
}
