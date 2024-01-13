using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Domain.Models;

namespace BestGarden.Application.Contracts;
public interface IOrderItemRepository : IGenericRepository<OrderItem>
{
}
