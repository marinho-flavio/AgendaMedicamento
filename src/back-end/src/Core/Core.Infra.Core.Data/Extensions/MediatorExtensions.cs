﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SES.Core.Domain.Aggregates.CommonAgg.Entities;

namespace SES.Core.Infra.Data.Extensions
{
    public static class MediatorExtension
    {
        public static async Task PublishDomainEvents<T>(this IMediator mediator, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            var tasks = domainEvents
                .Select(async (domainEvent) => {
                    await mediator.Publish(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
