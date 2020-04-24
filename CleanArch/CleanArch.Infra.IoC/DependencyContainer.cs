using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Commands;
using CleanArch.Domain.CommandsHandler;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServies(IServiceCollection services)
        {
            //MediateR
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            // Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();


            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddDbContext<UniversityDBContext>();
        }
    }
}
