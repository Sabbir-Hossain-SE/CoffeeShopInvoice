namespace assignment2
{
    partial class CoffeeShop
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.alertQuantity = new System.Windows.Forms.Label();
            this.alertOrder = new System.Windows.Forms.Label();
            this.alertAddress = new System.Windows.Forms.Label();
            this.alertContact = new System.Windows.Forms.Label();
            this.alertName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.orderOption = new System.Windows.Forms.ComboBox();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.contactField = new System.Windows.Forms.TextBox();
            this.cusNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.alertQuantity);
            this.groupBox.Controls.Add(this.alertOrder);
            this.groupBox.Controls.Add(this.alertAddress);
            this.groupBox.Controls.Add(this.alertContact);
            this.groupBox.Controls.Add(this.alertName);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.orderOption);
            this.groupBox.Controls.Add(this.quantityField);
            this.groupBox.Controls.Add(this.addressField);
            this.groupBox.Controls.Add(this.contactField);
            this.groupBox.Controls.Add(this.cusNameField);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 30);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(508, 400);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cutomer Information";
            // 
            // alertQuantity
            // 
            this.alertQuantity.AutoSize = true;
            this.alertQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.alertQuantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertQuantity.Location = new System.Drawing.Point(204, 325);
            this.alertQuantity.Name = "alertQuantity";
            this.alertQuantity.Size = new System.Drawing.Size(0, 13);
            this.alertQuantity.TabIndex = 15;
            // 
            // alertOrder
            // 
            this.alertOrder.AutoSize = true;
            this.alertOrder.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertOrder.Location = new System.Drawing.Point(204, 267);
            this.alertOrder.Name = "alertOrder";
            this.alertOrder.Size = new System.Drawing.Size(0, 13);
            this.alertOrder.TabIndex = 14;
            // 
            // alertAddress
            // 
            this.alertAddress.AutoSize = true;
            this.alertAddress.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertAddress.Location = new System.Drawing.Point(204, 176);
            this.alertAddress.Name = "alertAddress";
            this.alertAddress.Size = new System.Drawing.Size(0, 13);
            this.alertAddress.TabIndex = 13;
            // 
            // alertContact
            // 
            this.alertContact.AutoSize = true;
            this.alertContact.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertContact.Location = new System.Drawing.Point(204, 125);
            this.alertContact.Name = "alertContact";
            this.alertContact.Size = new System.Drawing.Size(0, 13);
            this.alertContact.TabIndex = 12;
            // 
            // alertName
            // 
            this.alertName.AutoSize = true;
            this.alertName.ForeColor = System.Drawing.Color.OrangeRed;
            this.alertName.Location = new System.Drawing.Point(204, 72);
            this.alertName.Name = "alertName";
            this.alertName.Size = new System.Drawing.Size(0, 13);
            this.alertName.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderOption
            // 
            this.orderOption.FormattingEnabled = true;
            this.orderOption.Items.AddRange(new object[] {
            "Black",
            "Hot",
            "Cold",
            "Regular"});
            this.orderOption.Location = new System.Drawing.Point(241, 242);
            this.orderOption.Name = "orderOption";
            this.orderOption.Size = new System.Drawing.Size(128, 21);
            this.orderOption.TabIndex = 9;
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(204, 298);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(165, 20);
            this.quantityField.TabIndex = 8;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(204, 149);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(165, 20);
            this.addressField.TabIndex = 7;
            // 
            // contactField
            // 
            this.contactField.Location = new System.Drawing.Point(204, 98);
            this.contactField.Name = "contactField";
            this.contactField.Size = new System.Drawing.Size(165, 20);
            this.contactField.TabIndex = 6;
            // 
            // cusNameField
            // 
            this.cusNameField.Location = new System.Drawing.Point(204, 45);
            this.cusNameField.Name = "cusNameField";
            this.cusNameField.Size = new System.Drawing.Size(165, 20);
            this.cusNameField.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // invoice
            // 
            this.invoice.Location = new System.Drawing.Point(557, 30);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(231, 400);
            this.invoice.TabIndex = 1;
            this.invoice.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(638, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "**INVOICE**";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.groupBox);
            this.Name = "CoffeeShop";
            this.Text = "CoffeeShop";
            this.Load += new System.EventHandler(this.CoffeeShop_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox invoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox orderOption;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.TextBox contactField;
        private System.Windows.Forms.TextBox cusNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label alertQuantity;
        private System.Windows.Forms.Label alertOrder;
        private System.Windows.Forms.Label alertAddress;
        private System.Windows.Forms.Label alertContact;
        private System.Windows.Forms.Label alertName;
    }
}

