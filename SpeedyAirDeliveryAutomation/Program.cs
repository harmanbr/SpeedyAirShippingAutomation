using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.Console;
using SpeedyAirDeliveryAutomation.Flight;
using SpeedyAirShippingAutomation;
using SpeedyAirShippingAutomationLibrary.BatchOrder;
using SpeedyAirShippingAutomationLibrary.BusinessLogic;
using SpeedyAirShippingAutomationLibrary.FlightSchedule;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;


try
{
    services.GetRequiredService<ILoadBoxes>().Run();
}

catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IFlightModel, FlightModel>();
            services.AddSingleton<IFlightScheduleModel, FlightScheduleModel>();
            services.AddSingleton<ILoadBoxes, LoadBoxes>();
            services.AddSingleton<IAssignmentLoader, AssignmentLoader>();
            services.AddTransient<IPrintFlightSchedule, PrintFlightSchedule>();
            services.AddTransient<IGenerateItineraries, GenerateItineraries>();
            services.AddTransient<IPrintBatchOrders, PrintBatchOrders>();
            services.AddSingleton<ILoadFlights, LoadFlights>();

        });

}