using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infrastructure.Persistence
{
   public class MongoDbOptions
    {
        public string Database { get; set; }
        public string ConnectionString { get; set; }
    }
}
