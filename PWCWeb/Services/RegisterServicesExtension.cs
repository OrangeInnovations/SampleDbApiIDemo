﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sox.Services.DataServices;
using Sox.Services.Models;

namespace PWCWeb.Services
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Sample_DbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SampleDb")));

            services.AddScoped<IDataServices, SampleDbDataServices>();
        }
    }
}
