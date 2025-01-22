using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Invoices
{
    public partial class f_Invoices : Form
    {
        public f_Invoices()
        {
            InitializeComponent();
        }
        private long fibonacciSpeed = 35;
        //Inventory data
        //with inventory item ID, inventory item name, and cost
        Inventory[] invent =
        {
            new Inventory(1234, "blue ink pen", 1.19),
            new Inventory(1235, "black ink pen", 1.19),
            new Inventory(1236, "red ink pen", 1.19),
            new Inventory(2134, "blue pencil", .79),
            new Inventory(2135, "black pencil", .79),
            new Inventory(2136, "red pencil", .79),
            new Inventory(3124, "large eraser", 2.59),
            new Inventory(3125, "medium eraser", 1.59),
            new Inventory(3126, "cap eraser", .89),
            new Inventory(6233, "clear pushpins", 7.50),
            new Inventory(6234, "white pushpins", 7.50),
            new Inventory(6235, "green pushpins", 7.50),
            new Inventory(6236, "red pushpins", 7.50),
            new Inventory(6237, "blue pushpins", 7.50),
            new Inventory(6238, "yellow pushpins", 7.50),
            new Inventory(6239, "mixed pushpins", 7.50),
            new Inventory(5671, "small stapler", 4.25),
            new Inventory(5789, "stand stapler", 4.50),
            new Inventory(5312, "small staples", 1.25),
            new Inventory(5313, "large staples", 3.75)
        };

        //with customer ID, first name, and last name
        Customer[] cust =
        {
            new Customer(876, "Mary", "Johnson"),
            new Customer(490, "Larry", "Brooks"),
            new Customer(552, "Ann", "Masters"),
            new Customer(923, "Frank", "Jones"),
            new Customer(259, "Gary", "Martin")
        };

        //Invoice data
        //with invoice ID, customer ID, and a date(mm, dd, yyyy)
        Invoice[] theInvoice =
        {
            new Invoice(22, 876, 5, 2, 2019),
            new Invoice(25, 876, 5, 3, 2019),
            new Invoice(26, 259, 5, 4, 2019),
            new Invoice(27, 490, 2, 28, 2018),
            new Invoice(28, 923, 3, 15, 2018),
            new Invoice(30, 552, 8, 10, 2018)
        };

        //Invoice Line Items data
        //with invoice ID, line item number, inventory item ID, and quantity sold
        InvoiceItem[] theInvoiceItem =
        {
            new InvoiceItem(22, 1, 1234, 5),
            new InvoiceItem(22, 2, 1235, 5),
            new InvoiceItem(22, 3, 1236, 5),
            new InvoiceItem(22, 4, 6233, 5),
            new InvoiceItem(22, 5, 6239, 5),

            new InvoiceItem(25, 1, 5671, 1),
            new InvoiceItem(25, 2, 5312, 2),
            new InvoiceItem(25, 3, 2135, 2),
            new InvoiceItem(25, 4, 6239, 2),

            new InvoiceItem(30, 1, 2135, 10),
            new InvoiceItem(30, 2, 2136, 10),
            new InvoiceItem(30, 3, 1234, 10),
            new InvoiceItem(30, 4, 1235, 10),
            new InvoiceItem(30, 5, 6239, 10),

            new InvoiceItem(26, 1, 5789, 5),
            new InvoiceItem(26, 2, 5671, 3),
            new InvoiceItem(26, 3, 5312, 5),
            new InvoiceItem(26, 4, 5313, 2),
            new InvoiceItem(26, 5, 6239, 2),

            new InvoiceItem(27, 1, 3124, 4),
            new InvoiceItem(27, 2, 3125, 4),
            new InvoiceItem(27, 3, 2135, 4),
            new InvoiceItem(27, 4, 6239, 4),

            new InvoiceItem(28, 1, 6234, 4),
            new InvoiceItem(28, 2, 6235, 4),
            new InvoiceItem(28, 3, 6236, 4),
            new InvoiceItem(28, 4, 6237, 4),
            new InvoiceItem(28, 5, 6239, 4),
            new InvoiceItem(28, 6, 6238, 4)
        };

        private void rb_CustomersByLastName_CheckedChanged(object sender, EventArgs e)
        {
            var customers =
                from em in cust
                orderby em.LastName
                select em;
            //reset the employee rich text box
            rtb_Customers.Text = "";

            //populate rich text box
            foreach (Customer em in customers)
            {
                if (rtb_Customers.Text == "")
                {
                    rtb_Customers.Text = $"{em.CustomerID,-4} {em.LastName + ", " + em.FirstName,-18}";
                }
                else
                {
                    rtb_Customers.AppendText($"\n{em.CustomerID,-4} {em.LastName + ", " + em.FirstName,-18}");
                }
            }
        }

        private void rb_CustomersByID_CheckedChanged(object sender, EventArgs e)
        {
            var customers =
                from em in cust
                orderby em.CustomerID
                select em;
            //reset the customer rich text box
            rtb_Customers.Text = "";

            //populate rich text box
            foreach (Customer em in customers)
            {
                if (rtb_Customers.Text == "")
                {
                    rtb_Customers.Text = em.ToString();
                }
                else
                {
                    rtb_Customers.AppendText($"\n{em.ToString()}");
                }
            }
        }

        private void rb_InventoryByID_CheckedChanged(object sender, EventArgs e)
        {
            var inventory =
                from em in invent
                orderby em.InventoryItemID
                select em;
            //reset the customer rich text box
            rtb_Customers.Text = "";

            //populate rich text box
            foreach (Inventory em in inventory)
            {
                if (rtb_Customers.Text == "")
                {
                    rtb_Customers.Text = em.ToString();
                }
                else
                {
                    rtb_Customers.AppendText($"\n{em.ToString()}");
                }
            }
        }

        private void rb_InventoryByCost_CheckedChanged(object sender, EventArgs e)
        {
            var inventory =
                from em in invent
                orderby em.InventoryItemID
                select new {em.Cost, em.InventoryItemID, em.InventoryName };
            //reset the customer rich text box
            rtb_Customers.Text = "";

            //populate rich text box
            foreach (var em in inventory)
            {
                string theCost = $"{em.Cost:C}";
                if (rtb_Customers.Text == "")
                {
                    rtb_Customers.Text = $"{theCost,7} {em.InventoryItemID,4} {em.InventoryName,-16}";
                }
                else
                {
                    rtb_Customers.AppendText($"\n{theCost,7} {em.InventoryItemID,4} {em.InventoryName,-16}");
                }
            }
        }
        private async void rb_Invoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Invoices.Checked == true)
            {
                var newVar = from i in theInvoice
                             join c in cust
                             on i.CustomerID equals c.CustomerID
                             group new
                             {
                                 i.InvoiceId,
                                 i.CustomerID,
                                 c.FirstName,
                                 c.LastName,
                                 i.InvoiceDate,
                             } by i.InvoiceId;

                //reset the customer rich text box
                rtb_Invoices.Clear();

                //Declare grand total
                double grandTotal = 0.0;

                //add the label
                rtb_Invoices.Text = "Invoices";

                //slow down the report (change all the FibonacciTask speeds at the top of this document)
                Task<long> newNumber = Task.Run(() => FibonacciTask(fibonacciSpeed));
                await newNumber;

                foreach (var item in newVar)
                {
                    rtb_Invoices.AppendText($"\n\nInvoice {item.Key,2}");
                    double subTotal = 0.0;

                    foreach (var item2 in item)
                    {
                        string dateString = $"Date {item2.InvoiceDate}";
                        rtb_Invoices.AppendText($"\nCustomer {item2.CustomerID + " " + item2.FirstName + " " + item2.LastName,-20} {dateString,15}");
                        var newVar2 = from i in item
                                      join ii in theInvoiceItem
                                      on i.InvoiceId equals ii.InvoiceID
                                      join inv in invent
                                      on ii.InventoryItemID equals inv.InventoryItemID
                                      let Total = inv.Cost * ii.QuantitySold
                                      orderby ii.LineItemNumber
                                      group new
                                      {
                                          i.InvoiceId,
                                          i.CustomerID,
                                          ii.LineItemNumber,
                                          inv.InventoryName,
                                          inv.Cost,
                                          ii.QuantitySold,
                                          Total
                                      } by i.InvoiceId;
                        foreach (var item3 in newVar2)
                        {
                            foreach (var item4 in item3)
                            {
                                string itemCostString = $"@ {item4.Cost:C}";
                                double totalCost = item4.Cost * item4.QuantitySold;
                                subTotal += totalCost;
                                grandTotal += totalCost;
                                string totalCostString = $"{totalCost:C}";
                                rtb_Invoices.AppendText($"\n{item4.LineItemNumber,2} {item4.InventoryName,-15} {itemCostString,11} {"qty sold " + item4.QuantitySold,11} {totalCostString,11} ");
                            }

                        }
                    }
                    rtb_Invoices.AppendText($"\nTotal for invoice: {subTotal:C}");
                }
                rtb_Invoices.AppendText($"\n\nTotal\t\t {grandTotal:C}");
            }
        }
        private async void rb_InventorySold_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_InventorySold.Checked == true)
            {
                var newVar =
            from i in theInvoiceItem
            join inv in invent
            on i.InventoryItemID equals inv.InventoryItemID
            orderby i.InventoryItemID
            group new { i.InvoiceID, i.InventoryItemID, i.QuantitySold, inv.Cost } by i.InventoryItemID;

                //reset the customer rich text box
                rtb_Invoices.Clear();

                //Declare grand total
                double grandTotal = 0.0;

                //add the label
                rtb_Invoices.Text = "Inventory Changes";

                //slow down the report (change all the FibonacciTask speeds at the top of this document)
                Task<long> newNumber = Task.Run(() => FibonacciTask(fibonacciSpeed));
                await newNumber;

                    foreach (var item in newVar)
                    {
                        rtb_Invoices.AppendText($"\n\nInventory item: {item.Key}");
                        double totalSold = 0.0;
                        foreach (var item2 in item)
                        {
                            double theCost = item2.QuantitySold * item2.Cost;
                            totalSold += theCost;
                            grandTotal += theCost;
                            string theCostString = $"cost {theCost:C}";
                            rtb_Invoices.AppendText($"\n   Invoice {item2.InvoiceID,2} {"sold " + item2.QuantitySold,2} {theCostString,6}");
                        }
                        rtb_Invoices.AppendText($"\n   Total sold: {totalSold:C}");
                    }
                    rtb_Invoices.AppendText($"\n\nTotal\t\t {grandTotal:C}");
            }
        }
        private async void rb_InvoicesByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_InvoicesByCustomer.Checked == true)
            {
                var invo =
                from em in theInvoice
                join thi in theInvoiceItem
                on em.InvoiceId equals thi.InvoiceID
                join theInventory in invent
                on thi.InventoryItemID equals theInventory.InventoryItemID
                let Total = theInventory.Cost * thi.QuantitySold
                group new { em.CustomerID, em.InvoiceId, Total } by em.CustomerID into combiine
                orderby combiine.Key
                select combiine;
                //reset the customer rich text box
                //rtb_Invoices.SelectAll();
                rtb_Invoices.Clear();

                //add the label
                rtb_Invoices.Text = "Invoices Sorted by Customer";

                //slow down the report (change all the FibonacciTask speeds at the top of this document)
                Task<long> newNumber = Task.Run(() => FibonacciTask(fibonacciSpeed));
                await newNumber;

                //Declare grand total
                double grandTotal = 0.0;

                    //populate rich text box
                    foreach (var em in invo)
                    {
                        rtb_Invoices.AppendText($"\n\nCustomer {em.Key}");
                        var iiiinvo = from iiinvo in em
                                      group iiinvo by iiinvo.InvoiceId;

                        foreach (var iinvo in iiiinvo)
                        {

                            double theSum = (from i in iinvo
                                             select i.Total).Sum();
                            rtb_Invoices.AppendText($"\n  Invoice {iinvo.Key} Total {theSum:C}");
                            grandTotal += theSum;
                        }
                    }
                    rtb_Invoices.AppendText($"\n\nTotal\t\t {grandTotal:C}");
            }
        }
        public async Task<long> FibonacciTask(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonacciTask(n - 1).Result + FibonacciTask(n - 2).Result;
            }
        }
    }
}
