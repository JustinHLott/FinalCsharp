using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    internal class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerID { get; set; }
        public Date InvoiceDate { get; set; }
        public Invoice(int invoiceId, int customerID, int month, int day, int year)
        {
            InvoiceId = invoiceId;
            CustomerID = customerID;
            Date date = new Date(year, month, day);
            InvoiceDate = date;
        }
    }
}
