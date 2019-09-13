using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace assignment2
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = cusNameField.Text, contact = contactField.Text, address = addressField.Text, order = orderOption.Text, quantity1 = quantityField.Text;
            int quantity =0, hotP = 90, regularP = 80, blackP = 120, coldP = 100, price;
            bool flagQuantity = Regex.IsMatch(quantity1, "[0-9]{1,}$"), flagContact = Regex.IsMatch(contact, "[0-9]{11,11}$"),pivCon=true,pivQuan=true;
            if (name.Length==0|| contact.Length==0|| address.Length == 0 || order.Length == 0 || quantity1.Length == 0|| flagQuantity==false|| flagContact==false)
            {
                if (name.Length == 0)
                {
                    alertName.Text = "*Please input the name field.";
                }
                else
                {
                    alertName.Text = "";
                }
                if (contact.Length == 0)
                {
                    alertContact.Text = "*Please input the contact field, use number only.";

                }
                else
                {
                    if (flagContact == false && contact.Length != 0)
                    {
                        alertContact.Text = "*Input incorrect syntax, use number only & use just 11 digits.";
                       
                    }
                    else 
                    {
                        alertContact.Text = "";
                    }
                }

                if (address.Length == 0)
                {
                    alertAddress.Text = "*Please input the address field.";
                }
                else
                {
                    alertAddress.Text = "";
                }
                if (order.Length == 0)
                {
                    alertOrder.Text = "*Please input the name field";
                }
                else
                {
                    alertOrder.Text = "";
                }

                if (quantity1.Length == 0)
                {
                    alertQuantity.Text = "*Please input the Quantity field, use number only.";
                }
                else
                {
                    alertQuantity.Text = "";
                    if (flagQuantity == false && quantity1.Length != 0)
                    {
                        alertQuantity.Text = "*Input incorrect syntax, use number only.";
                    }
                    else
                    {
                        alertQuantity.Text = "";
                    }
                }

            }

            else
            {
                quantity = Convert.ToInt32(quantity1);


                if (order == "black")
                {
                    price = blackP * quantity;
                    invoice.Text = price.ToString();
                }
                else if (order == "cold")
                {
                    price = coldP * quantity;

                }
                else if (order == "hot")
                {
                    price = hotP * quantity;

                }
                else
                {
                    price = regularP * quantity;
                }
                invoice.Text = "\n\n\n\n\n  Name\t\t: " + name + "\n  Contact Number  : " + contact + "\n  Address\t\t: " + address + "\n  Order Item\t   :\t" + order + "\n  Quantity\t\t:\t" + quantity + "\n  Total Price  (" + quantity + "*" + price / quantity + "):\t\t" + price;
            }
           
        }


    }
}



 