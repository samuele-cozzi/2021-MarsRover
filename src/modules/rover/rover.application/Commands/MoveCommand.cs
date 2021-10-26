﻿using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using rover.application.Aggregates;
using rover.application.Entities;
using rover.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover.application.Commands
{
    public  class MoveCommand : Command<MoveAggregate, MoveId, IExecutionResult>
    {
        public MoveCommand(MoveId aggregateId, string[] move) : base(aggregateId)
        {
            Move = move;
        }

        public string[] Move { get; }
    }
}
