using System;
using System.Linq;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Catalog
{
    private static List<Product> productCatalog = new List<Product>();
    private static List<Equipment> equipmentCatalog = new List<Equipment>();

     public void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
        }

        public void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        public void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        public Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        public Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        public Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        public Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }

}


}

