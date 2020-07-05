﻿using Microsoft.Extensions.DependencyInjection;
using System;
using WebApplication.Core.Data.Concrete;
using WebApplication.Core.Data.Interfaces;

namespace WebApplication.Core.UI.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            return collection;
        }


    }
}
