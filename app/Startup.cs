#define _LINUX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Formatters;
using Smitten.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Smitten.Api.Services;
using Smitten.Api.Models;

namespace Smitten.Api
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);

            services.AddMvc(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
                setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                setupAction.InputFormatters.Add(new XmlDataContractSerializerInputFormatter());
            });

            services.AddDbContext<SmittenContext>(o => o.UseSqlite(_config["ConnectionStrings:Sqlite"]));
            // services.AddDbContext<SmittenContext>(o => o.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]));

            services.AddScoped<ISmittenRepository, SmittenRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SmittenContext smittenContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                smittenContext.EnsureSeedDataForDevelopment();
            }

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Person, PersonDto>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                 .ForMember(dest => dest.NumberOfSmites, opt => opt.MapFrom(src => src.Smites.Count));
                cfg.CreateMap<Smite, SmiteDto>();
                cfg.CreateMap<PersonForCreationDto, Person>();
                cfg.CreateMap<SmiteForCreationDto, Smite>();
            });

            app.UseMvc();
        }
    }
}
