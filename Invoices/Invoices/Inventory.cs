using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    internal class Inventory// new Inventory(1234, "blue ink pen", 1.19),//with inventory item ID, inventory item name, and cost
    {
        public int InventoryItemID {get; set;}
        public string InventoryName {get; set;}
        public double Cost { get; set;}

        public Inventory(int inventoryItemID, string inventoryName, double cost)
        {
            this.InventoryItemID = inventoryItemID;
            this.InventoryName = inventoryName;
            this.Cost = cost;
        }
        public override string ToString()
        {
            string theCost = $"{Cost:C}";
            return $"{InventoryItemID,4} {InventoryName,-16} {theCost,6}";
        }
    }
}
