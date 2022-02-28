using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Core.Entities
{
    public interface IEntityBase
    {
        Guid Id { get; }
    }
}
