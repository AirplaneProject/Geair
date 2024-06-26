﻿using Geair.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geair.Application.Mediator.Results.ReservationTravelResults
{
    public class GetReservationTravelByIdQueryResult
    {
        public int ReservationTravelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? UserNameSurname { get; set; }
        public int? UserId { get; set; }
        public int TravelId { get; set; }
        public string TravelTitle { get; set; }
        public int PersonCount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
