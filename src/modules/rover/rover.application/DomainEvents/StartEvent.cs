﻿using EventFlow.Aggregates;
using rover.application.Aggregates;
using rover.application.Models;
using rover.domain.AggregateModels.Rover;
using System;
using System.Collections.Generic;
using System.Text;

namespace rover.application.DomainEvents
{
    public class StartEvent : AggregateEvent<StartAggregate, StartId>
    {
        public Moves[] Move { get; }
        public bool Stop { get; set; }

        public StartEvent(Moves[] move, bool stop)
        {
            this.Move = move;
            this.Stop = stop;
        }

    }
}
