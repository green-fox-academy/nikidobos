using fashionstoregf.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fashionstoregf.Repositories
{
    public class WarehouseRepository : IGeneralRepo<Warehouse>
    {
        public gffashionstoreContext dbContext;
        public WarehouseRepository(gffashionstoreContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Warehouse warehouse)
        {
            dbContext.Warehouses.Add(warehouse);
            dbContext.SaveChanges();
        }

        public List<Warehouse> Read()
        {
            return dbContext.Warehouses.ToList();
        }

        public void Update(Warehouse warehouse)
        {
            dbContext.Warehouses.Update(warehouse);
            dbContext.SaveChanges();
        }

        public void Delete(Warehouse warehouse)
        {
            dbContext.Warehouses.Remove(warehouse);
            dbContext.SaveChanges();
        }

        public List<string> GetAllItemNames()
        {
            return dbContext.Warehouse
                .Include(warehouse => warehouse.ItemName).GroupBy(w => w.ItemName).Select(x => x.Key)
                .ToList();
        }

        public List<string> GetAllSizes()
        {
            return dbContext.Warehouse
                .Include(warehouse => warehouse.Size).GroupBy(w => w.Size).Select(x => x.Key)
                .ToList();
        }
    }
}
