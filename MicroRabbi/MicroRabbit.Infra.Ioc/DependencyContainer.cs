using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.CommandsHandler;
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

            //Domain Banking Commands
            service.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();


            //Application Service
            service.AddTransient<IAccountService, AccountService>();

            //Data
            service.AddTransient<IAccountRepositry, AccountRepository>();
            service.AddTransient<BankingDbContext>();
          
        }
    }
}
