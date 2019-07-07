using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            //Domain Bus
            service.AddTransient<IEventBus, RabbitMQBus>();

            //Application Service
            service.AddTransient<IAccountService, AccountService>();

            //Data
            service.AddTransient<IAccountRepositry, AccountRepository>();
            service.AddTransient<BankingDbContext>();
          
        }
    }
}
