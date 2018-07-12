using fashionstoregf.Models;
using fashionstoregf.Repositories;
using fashionstoregf.ViewModesl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fashionstoregf.Service
{
    public class WarehouseService
    {
        public WarehouseRepository warehouseRepository;

        public WarehouseService(WarehouseRepository warehouseRepository)
        {
            this.warehouseRepository = warehouseRepository;
        }

        public void AddNewClothe(Warehouse ware)
        {
            warehouseRepository.Create(ware);
        }

        public List<Warehouse> GetAllClothes()
        {
            return warehouseRepository.Read().ToList();
        }

        public void UpdateClothe(Warehouse ware)
        {
            warehouseRepository.Update(ware);
        }

        public void DeleteClothe(Warehouse ware)
        {
            warehouseRepository.Delete(ware);
        }

        //public Warehouse GetByItemName(string itemName)
        //{
        //    return warehouseRepository.Read().FirstOrDefault(x => x.ItemName.Contains(itemName));
        //}

        public Warehouse GetItem(string itemName, string size)
        {
            var selectedItem = warehouseRepository.Read().FirstOrDefault((x => x.ItemName.Equals(itemName) && (x.Size.Equals(size))));
            return selectedItem;
        }

        public WarehouseViewModel GetSelection()
        {
            return new WarehouseViewModel()
            {
                Warehouses = warehouseRepository.Read(),
                Sizes = warehouseRepository.GetAllSize(),
                ItemNames = warehouseRepository.GetAllItemName()
            };
        }

        public SummaryViewModel Summarize(string ItemName, string Size, int Quantity)
        {
            var searchedItem = GetItem(ItemName, Size);
            return new SummaryViewModel()
            {
                ItemName = ItemName,
                Quantity = Quantity,
                SubtotalPrice = (double) searchedItem.UnitPrice * Quantity,
                Manufacturer = searchedItem.Manufacturer,
                Category = searchedItem.Category
            };
        }
    }
}
