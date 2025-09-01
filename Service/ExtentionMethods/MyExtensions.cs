﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ExtentionMethods
{
    public static class MyExtensions
    {
        public static void TryAttach<TContext, TEntity>(this TContext context, TEntity entity)
    where TContext : DbContext
    where TEntity : class?
        {
            if (entity == null)
            {
                return;
            }
            if (!context.Set<TEntity>().Local.Any(e => e == entity))
            {
                context.Set<TEntity>().Attach(entity);
                return;
            }
            var entityAttached = context.Set<TEntity>().Local.FirstOrDefault(e => e == entity);
            entity = entityAttached;
            return;
        }
    }
}
