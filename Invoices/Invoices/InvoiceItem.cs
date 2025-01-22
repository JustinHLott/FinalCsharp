using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    internal class InvoiceItem
    {
        //with invoice ID, line item number, inventory item ID, and quantity sold
        public int InvoiceID { get; set; }
        public int LineItemNumber { get; set; }
        public int InventoryItemID { get; set; }
        public int QuantitySold { get; set; }
        public InvoiceItem(int InvoiceID,int LineItemNumber, int InventoryItemID, int QuantitySold)
        {
            this.InvoiceID = InvoiceID;
            this.LineItemNumber = LineItemNumber;
            this.InventoryItemID = InventoryItemID;
            this.QuantitySold = QuantitySold;
        }
    }
}
