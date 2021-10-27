﻿using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using rover.application.Aggregates;
using rover.application.Entities;
using rover.application.Models;
using rover.domain.AggregateModels.Rover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover.application.Commands
{
    public  class MoveCommand : Command<MoveAggregate, MoveId, IExecutionResult>
    {
        public MoveCommand(MoveId aggregateId, Position position, Moves move) : base(aggregateId)
        {
            Move = move;
            Position = position;
        }

        public Moves Move { get; }
        public Position Position { get; }
    }
}
