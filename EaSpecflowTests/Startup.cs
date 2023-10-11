using EaApplicaitonTest.Pages;
using EaFrameWork.Config;
using EaFrameWork.Driver;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaSpecflowTests
{
 
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
           var services = new ServiceCollection();
            services
                .AddSingleton(ConfigReader.ReadConfig())
                .AddScoped<IDriverFixture, DriverFixture>()
                .AddScoped<IDriverWait, DriverWait>()
                .AddScoped<IHomePage, HomePage>()
                .AddScoped<IProductPage, ProductPage>();
            return services;
        }
            
    }
    }

