using EaFrameWork.Config;
using EaFrameWork.Driver;
using EaApplicaitonTest.Pages;
using Microsoft.Extensions.DependencyInjection;


namespace EaApplicaitonTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton(ConfigReader.ReadConfig())
                .AddScoped<IDriverFixture, DriverFixture>()
                .AddScoped<IDriverWait, DriverWait>()
                .AddScoped<IHomePage, HomePage>()
                .AddScoped<IProductPage, ProductPage>();
        }

    }
}
