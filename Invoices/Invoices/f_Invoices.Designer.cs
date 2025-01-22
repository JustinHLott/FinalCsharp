namespace Invoices
{
    partial class f_Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_CustomersByLastName = new System.Windows.Forms.RadioButton();
            this.rb_CustomersByID = new System.Windows.Forms.RadioButton();
            this.rb_InventoryByID = new System.Windows.Forms.RadioButton();
            this.rb_InventoryByCost = new System.Windows.Forms.RadioButton();
            this.rb_Invoices = new System.Windows.Forms.RadioButton();
            this.rb_InventorySold = new System.Windows.Forms.RadioButton();
            this.rb_InvoicesByCustomer = new System.Windows.Forms.RadioButton();
            this.rtb_Customers = new System.Windows.Forms.RichTextBox();
            this.rtb_Invoices = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rb_CustomersByLastName
            // 
            this.rb_CustomersByLastName.AutoSize = true;
            this.rb_CustomersByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_CustomersByLastName.Location = new System.Drawing.Point(13, 23);
            this.rb_CustomersByLastName.Name = "rb_CustomersByLastName";
            this.rb_CustomersByLastName.Size = new System.Drawing.Size(175, 20);
            this.rb_CustomersByLastName.TabIndex = 0;
            this.rb_CustomersByLastName.TabStop = true;
            this.rb_CustomersByLastName.Tag = "CustomerData";
            this.rb_CustomersByLastName.Text = "Customers by Last Name";
            this.rb_CustomersByLastName.UseVisualStyleBackColor = true;
            this.rb_CustomersByLastName.CheckedChanged += new System.EventHandler(this.rb_CustomersByLastName_CheckedChanged);
            // 
            // rb_CustomersByID
            // 
            this.rb_CustomersByID.AutoSize = true;
            this.rb_CustomersByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_CustomersByID.Location = new System.Drawing.Point(13, 49);
            this.rb_CustomersByID.Name = "rb_CustomersByID";
            this.rb_CustomersByID.Size = new System.Drawing.Size(123, 20);
            this.rb_CustomersByID.TabIndex = 1;
            this.rb_CustomersByID.TabStop = true;
            this.rb_CustomersByID.Tag = "CustomerData";
            this.rb_CustomersByID.Text = "Customers by ID";
            this.rb_CustomersByID.UseVisualStyleBackColor = true;
            this.rb_CustomersByID.CheckedChanged += new System.EventHandler(this.rb_CustomersByID_CheckedChanged);
            // 
            // rb_InventoryByID
            // 
            this.rb_InventoryByID.AutoSize = true;
            this.rb_InventoryByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_InventoryByID.Location = new System.Drawing.Point(13, 75);
            this.rb_InventoryByID.Name = "rb_InventoryByID";
            this.rb_InventoryByID.Size = new System.Drawing.Size(113, 20);
            this.rb_InventoryByID.TabIndex = 2;
            this.rb_InventoryByID.TabStop = true;
            this.rb_InventoryByID.Tag = "CustomerData";
            this.rb_InventoryByID.Text = "Inventory by ID";
            this.rb_InventoryByID.UseVisualStyleBackColor = true;
            this.rb_InventoryByID.CheckedChanged += new System.EventHandler(this.rb_InventoryByID_CheckedChanged);
            // 
            // rb_InventoryByCost
            // 
            this.rb_InventoryByCost.AutoSize = true;
            this.rb_InventoryByCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_InventoryByCost.Location = new System.Drawing.Point(13, 101);
            this.rb_InventoryByCost.Name = "rb_InventoryByCost";
            this.rb_InventoryByCost.Size = new System.Drawing.Size(127, 20);
            this.rb_InventoryByCost.TabIndex = 3;
            this.rb_InventoryByCost.TabStop = true;
            this.rb_InventoryByCost.Tag = "CustomerData";
            this.rb_InventoryByCost.Text = "Inventory by Cost";
            this.rb_InventoryByCost.UseVisualStyleBackColor = true;
            this.rb_InventoryByCost.CheckedChanged += new System.EventHandler(this.rb_InventoryByCost_CheckedChanged);
            // 
            // rb_Invoices
            // 
            this.rb_Invoices.AutoSize = true;
            this.rb_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Invoices.Location = new System.Drawing.Point(330, 12);
            this.rb_Invoices.Name = "rb_Invoices";
            this.rb_Invoices.Size = new System.Drawing.Size(75, 20);
            this.rb_Invoices.TabIndex = 4;
            this.rb_Invoices.TabStop = true;
            this.rb_Invoices.Tag = "InvoiceData";
            this.rb_Invoices.Text = "Invoices";
            this.rb_Invoices.UseVisualStyleBackColor = true;
            this.rb_Invoices.CheckedChanged += new System.EventHandler(this.rb_Invoices_CheckedChanged);
            // 
            // rb_InventorySold
            // 
            this.rb_InventorySold.AutoSize = true;
            this.rb_InventorySold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_InventorySold.Location = new System.Drawing.Point(478, 12);
            this.rb_InventorySold.Name = "rb_InventorySold";
            this.rb_InventorySold.Size = new System.Drawing.Size(110, 20);
            this.rb_InventorySold.TabIndex = 5;
            this.rb_InventorySold.TabStop = true;
            this.rb_InventorySold.Tag = "InvoiceData";
            this.rb_InventorySold.Text = "Inventory Sold";
            this.rb_InventorySold.UseVisualStyleBackColor = true;
            this.rb_InventorySold.CheckedChanged += new System.EventHandler(this.rb_InventorySold_CheckedChanged);
            // 
            // rb_InvoicesByCustomer
            // 
            this.rb_InvoicesByCustomer.AutoSize = true;
            this.rb_InvoicesByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_InvoicesByCustomer.Location = new System.Drawing.Point(623, 12);
            this.rb_InvoicesByCustomer.Name = "rb_InvoicesByCustomer";
            this.rb_InvoicesByCustomer.Size = new System.Drawing.Size(153, 20);
            this.rb_InvoicesByCustomer.TabIndex = 6;
            this.rb_InvoicesByCustomer.TabStop = true;
            this.rb_InvoicesByCustomer.Tag = "InvoiceData";
            this.rb_InvoicesByCustomer.Text = "Invoices by Customer";
            this.rb_InvoicesByCustomer.UseVisualStyleBackColor = true;
            this.rb_InvoicesByCustomer.CheckedChanged += new System.EventHandler(this.rb_InvoicesByCustomer_CheckedChanged);
            // 
            // rtb_Customers
            // 
            this.rtb_Customers.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Customers.Location = new System.Drawing.Point(13, 143);
            this.rtb_Customers.Name = "rtb_Customers";
            this.rtb_Customers.Size = new System.Drawing.Size(290, 807);
            this.rtb_Customers.TabIndex = 9;
            this.rtb_Customers.Text = "";
            // 
            // rtb_Invoices
            // 
            this.rtb_Invoices.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Invoices.Location = new System.Drawing.Point(316, 57);
            this.rtb_Invoices.Name = "rtb_Invoices";
            this.rtb_Invoices.Size = new System.Drawing.Size(472, 893);
            this.rtb_Invoices.TabIndex = 10;
            this.rtb_Invoices.Text = "";
            // 
            // f_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.rb_CustomersByLastName);
            this.Controls.Add(this.rb_CustomersByID);
            this.Controls.Add(this.rb_InvoicesByCustomer);
            this.Controls.Add(this.rb_InventoryByID);
            this.Controls.Add(this.rtb_Invoices);
            this.Controls.Add(this.rb_InventoryByCost);
            this.Controls.Add(this.rb_Invoices);
            this.Controls.Add(this.rb_InventorySold);
            this.Controls.Add(this.rtb_Customers);
            this.Name = "f_Invoices";
            this.Text = "Invoices - final project by Justin Lott";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_CustomersByLastName;
        private System.Windows.Forms.RadioButton rb_CustomersByID;
        private System.Windows.Forms.RadioButton rb_InventoryByID;
        private System.Windows.Forms.RadioButton rb_InventoryByCost;
        private System.Windows.Forms.RadioButton rb_Invoices;
        private System.Windows.Forms.RadioButton rb_InventorySold;
        private System.Windows.Forms.RadioButton rb_InvoicesByCustomer;
        private System.Windows.Forms.RichTextBox rtb_Customers;
        private System.Windows.Forms.RichTextBox rtb_Invoices;
    }
}

