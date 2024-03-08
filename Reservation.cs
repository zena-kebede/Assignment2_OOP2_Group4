using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Components.Pages.Data
{
    internal class Reservation
    {
        ///
        ///Represents a reservation for a flight.
        ///

        //Constrant that is representing the size of each reservation record.
        public const int RECORD_SIZE = 201;

        // Private fields representing reservation attributes
        private string code;
        private string flightCode;
        private string airline;
        private string name;
        private string citizenship;
        private double cost;
        private string active;
        private string reservationCode;
        private Flight flight;

        public Reservation()
        {
        }

        ///
        /// Constructor for initializing a reservation with basic information
        ///        
        public Reservation(string code, string flightCode, string airline, double cost, string name, string citizenship, string active)
        {
            this.code = code;
            this.flightCode = flightCode;
            this.airline = airline;
            this.name = name;
            this.citizenship = citizenship;
            this.cost = cost;
            this.active = active;
        }

        //Constructor for intializing a reservation with flight and passenger information incl.  
        public Reservation(string reservationCode, Flight flight, string name, string citizenship)
        {
            this.reservationCode = reservationCode;
            this.flight = flight;
            this.name = name;
            this.citizenship = citizenship;
        }

        // Accessing private fields
        public string Code { get => code; set => code = value; }
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string Airline { get => airline; set => airline = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public double Cost { get => cost; set => cost = value; }
        public string Active { get => active; set => active = value; }

        //Sets the name of the passenger
        public void SetName(string name)// throws InvalidNameException
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name"); //thrown when the passenger name is NULL or empty.
            }

            this.name = name;
        }

        //Sets the citizenship of the passenger.
        public void setCitizenship(string citizenship) //throws InvalidCitizenshipException
        {
            if (string.IsNullOrEmpty(citizenship))
            {
                throw new Exception();//InvalidCitizenshipException
            }

            this.citizenship = citizenship;
        }

        //Return a string version of the reservation.
        public string toString()
        {
            // return this.Code;
            return $"{Code}, {FlightCode}, {Airline}, {Cost}, {Name}, {Citizenship}, {Active}";

        }
    }
}

