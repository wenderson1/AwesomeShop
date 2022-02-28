﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infrastructure.MessageBus
{
   public interface IMessageBusClient
    {
        void Publish(object message, string routingKey, string exchange);
    }
}
