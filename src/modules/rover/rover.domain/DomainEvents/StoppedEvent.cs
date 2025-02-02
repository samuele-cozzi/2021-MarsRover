﻿using EventFlow.Aggregates;
using EventFlow.EventStores;
using rover.domain.Aggregates;
using rover.domain.Models;

namespace rover.domain.DomainEvents
{
    [EventVersion("positionchanged", 1)]
    public class StoppedEvent : AggregateEvent<RoverAggregate, RoverAggregateId>
    {
        public FacingDirections FacingDirection { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public bool IsBlocked { get; }
        public bool Stop { get; set; }

        public StoppedEvent(FacingDirections facingDirection, double latitude, double longitude, bool isBlocked, bool stop)
        {
            this.FacingDirection = facingDirection;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.IsBlocked = isBlocked;
            this.Stop = stop;
        }

    }
}
