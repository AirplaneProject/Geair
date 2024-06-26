﻿namespace Geair.WebUI.Areas.Admin.Dtos.FlightDtos
{
    public class CreateFlightDto
    {
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AircraftId { get; set; }
        public bool Status { get; set; }
        public decimal EconomyPrice { get; set; }
        public decimal BusinessPrice { get; set; }
        public string FlightType { get; set; }
        public DateTime? DateOfReturn { get; set; }
    }
}
