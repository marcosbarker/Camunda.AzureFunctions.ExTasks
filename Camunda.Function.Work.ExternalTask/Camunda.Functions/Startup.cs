using Camunda.Functions.Servicos;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(Camunda.Functions.Startup))]

namespace Camunda.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //throw new NotImplementedException();

            builder.Services.AddHttpClient();
            builder.Services.AddScoped<ICamundaService, CamundaService>();
            builder.Services.AddScoped<SBService, SBService>();
            builder.Services.AddScoped<UserAgent, UserAgent>();
        }
    }
}