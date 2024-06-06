﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geair.Application.Mediator.Results.StatisticResults
{
    public class GetFlightCountQueryResult:IRequest<GetFlightCountQueryResult>
    {
        public int FlightCount { get; set; }
    }
}
