using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infrastructure.MessageBus
{
    public class ProducerConnection
    {
        public IConnection Connection { get; private set; }

        public ProducerConnection(IConnection connection)
        {
            Connection = connection;
        }
    }
}
