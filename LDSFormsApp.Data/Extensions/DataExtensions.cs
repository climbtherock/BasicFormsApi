using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LDSFormsApp.Data.Extensions
{
    public static class DataExtensions
    {
        public static void AddData(this IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=LDSForms;Trusted_Connection=True;";
            services.AddDbContext<LDSFormsAppContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IMeetingRepository), typeof(MeetingRepository));
            services.AddScoped(typeof(IAgendaItemRepository), typeof(AgendaItemRepository));
        }
    }
}
