using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2.Components.Pages.Data
{

    ///
    ///Represents information about a flight.
    ///
    /// This class enapsulates data related to a flight, including its code, airline, departure and destination location
    ///weekday, departure time, available seats, and cost per seat. It provides methods for parsing flight codes, checking
    ///if a flight is domestic, and generating string representations of flights.
    ///
    
    internal class Flight
    {
        //Constant representing the size of each flight record
        public const int RECORD_SIZE = 72;

        private string code;

        private string airline;

        private string from;

        private string to;

        private string weekday;

        private string time;


        private int seats;

        private double costPerSeat;

        //Constructor initializing only the code
        //private bool isSelected;

        public Flight(string code)
        {
            this.code = code;
        }

        //Constructor initializing all flight attributes
        public Flight(string code, string airline, string from, string to, string weekday, string time, int seats, double costPerSeat)
        {
            this.code = code;
            this.airline = airline;
            this.from = from;
            this.to = to;
            this.weekday = weekday;
            this.time = time;
            this.seats = seats;
            this.costPerSeat = costPerSeat;

        }
        
        //Properties for accessing private fields
        public string Code { get => code; set => code = value; }
        public string Airline { get => airline; set => airline = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Weekday { get => weekday; set => weekday = value; }
        public string Time { get => time; set => time = value; }
        public int Seats { get => seats; set => seats = value; }
        public double CostPerSeat { get => costPerSeat; set => costPerSeat = value; }

        //Override Equals method to compare two Flight objects
        public override bool Equals(object obj)
        {
            return obj is Flight flight &&
                   code == flight.code &&
                   airline == flight.airline &&
                   from == flight.from &&
                   to == flight.to &&
                   weekday == flight.weekday &&
                   time == flight.time &&
                   seats == flight.seats &&
                   costPerSeat == flight.costPerSeat &&
                   Code == flight.Code &&
                   Airline == flight.Airline &&
                   From == flight.From &&
                   To == flight.To &&
                   Weekday == flight.Weekday &&
                   Time == flight.Time &&
                   Seats == flight.Seats &&
                   CostPerSeat == flight.CostPerSeat;
        }
        
        //Check if the flight is domestic
        public bool isDomestic()
        {
            return From[0] == 'Y' && To[0] == 'Y';
        }
        
        //Return a string representation of the flight
        public string toString()
        {
            return Code;
        }

        //Parse flight code to extract the relative airline information
        private void ParseCode(string code) //throws InvalidFlightCodeException
        {
            //Check if the flight code matches expected format
            if (!Regex.Match(code, "^[A-Z]{2}-\\d{4}$").Success)
            {
                // Throwing exception for invalid flight code format
                throw new Exception();//InvalidFlightCodeException
            }

            //Map airline abbreviation to airline name
            string abbreviation = code.Substring(0, 2);

            switch (abbreviation)
            {
                case "OA":
                    airline = "Otto Airlines";
                    break;

                case "CA":
                    airline = "Conned Air";
                    break;

                case "TB":
                    airline = "Try a Bus Airways";
                    break;

                case "VA":
                    airline = "Vertical Airways";
                    break;

                default:
                    throw new Exception();//InvalidFlightCodeException
            }
        }

        public override int GetHashCode()
        {
            //Currently not implememnted
            throw new NotImplementedException();
        }
    }
}
