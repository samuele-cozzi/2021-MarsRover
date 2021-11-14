﻿using EventFlow.Core;
using EventFlow.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover.domain.Aggregates
{

    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class RoverPositionAggregateId : Identity<RoverPositionAggregateId>
    {
        public RoverPositionAggregateId(string value) : base(value) { }
    }
}
