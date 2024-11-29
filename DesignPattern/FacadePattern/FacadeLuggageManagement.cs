using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //Facade
    public class FacadeLuggageManagement
    {
        private AirportSystem airport;
        private Airplane plane; 
        private LocalTransportCompany company;
        private Hotel hotel; 

        public FacadeLuggageManagement()
        {
            airport = new AirportSystem();
            plane = new Airplane();
            company = new LocalTransportCompany();
            hotel = new Hotel();
        }

        public void SendLuggage()
        {
            airport.CheckLuggage();
            airport.TransportLuggageToAirplane();
            plane.PutLuggageIn();
            plane.PutLuggageOut();
            company.PutLuggageIntoTruck();
            company.TransportLuggageToHotel();
            hotel.TransportLuggageToRoom();
        }
    }
}
