﻿using EventFlow;
using EventFlow.Aggregates;
using EventFlow.Subscribers;
using Microsoft.Extensions.Hosting;
using rover.application.Aggregates;
using rover.application.Commands;
using rover.application.Entities;
using rover.application.Models;
using rover.infrastructure.rabbitmq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rover.application.DomainEvents
{
    public class MoveEventSubscriber : IHostedService, IRabbitMqConsumerPersistanceService, ISubscribeAsynchronousTo<MoveAggregate, MoveId, MoveEvent>
    {
        private static int i;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            i = 1;
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task HandleAsync(IDomainEvent<MoveAggregate, MoveId, MoveEvent> domainEvent, CancellationToken cancellationToken)
        {
            i++;
            Console.WriteLine($"Location Updated for {i}");
            


            return Task.CompletedTask;
        }

    }
}
