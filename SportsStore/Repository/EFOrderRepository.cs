using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Repository
{
    public class EFOrderRepository : IOrderRepository
    {
        private StoreDbContext _context;

        public IQueryable<Order> Orders => _context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public EFOrderRepository(StoreDbContext ctx)
        {
            _context = ctx;
        }
        
        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}