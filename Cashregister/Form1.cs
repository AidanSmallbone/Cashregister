using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashregister
{
    public partial class Form1 : Form
    {

        ///setting public variables to keep track of all value
        ///these are used throughout the program and between methods which is why they're public


        public int howManyItemOne;
        public int howManyItemTwo;
        public int howManyItemThree;
        public double itemOnePrice = 2.49;
        public double itemTwoPrice = 1.79;
        public double itemThreePrice = 0.99;
        public double subTotal;
        public double tax;
        public double total;
        public double howMuchCash;
        public double howMuchChange;
        public double taxRate = 0.13;

        public Form1()
        {
            InitializeComponent();
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {

        ///converts all of out values to ints so they can be calculated
        ///and adds the calculated values to variables that we then display to look like money

        howManyItemOne = Convert.ToInt32(itemOneAmount.Value);
        howManyItemTwo = Convert.ToInt32(itemTwoAmount.Value);
        howManyItemThree = Convert.ToInt32(itemThreeAmount.Value);

        subTotal = ((howManyItemOne * itemOnePrice) + (howManyItemTwo * itemTwoPrice) + (howManyItemThree * itemThreePrice));
        tax = (subTotal * taxRate);
        total = ((subTotal) + (subTotal * taxRate));

        subTotalAmountLabel.Text = subTotal.ToString(".##");
        taxAmountLabel.Text = tax.ToString(".##");
        totalAmountLabel.Text = total.ToString(".##");

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        ///this does basically the same thing as the last method but just for change

        howMuchCash = Convert.ToDouble(cashAmountTextBox.Text);
        howMuchChange = (howMuchCash - total);

        changeAmountLabel.Text = howMuchChange.ToString(".##");

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {

        ///resets all values to 0

        subTotal = 0;
        tax = 0;
        total = 0;
        howMuchCash = 0;
        howMuchChange = 0;
        howManyItemOne = 0;
        howManyItemTwo = 0;
        howManyItemThree = 0;

        itemOneAmount.Value = 0;
        itemTwoAmount.Value = 0;
        itemThreeAmount.Value = 0;

        subTotalAmountLabel.Text = "";
        taxAmountLabel.Text = "";
        totalAmountLabel.Text = "";
        cashAmountTextBox.Text = "";
        changeAmountLabel.Text = "";

        }

        private void printRecieptButton_Click(object sender, EventArgs e)
        {

        ///creates a few new variables
        ///and uses if statements and a graphics engine to show our values on a reciept

        string headerName = "Aidan's POS";
        string footerName = "Have a Nice Day!";
        bool itemOneOrdered;
        bool itemTwoOrdered;
        bool itemThreeOrdered;

        if (howManyItemOne != 0) { itemOneOrdered = true; } else { itemOneOrdered = false; };
        if (howManyItemTwo != 0) { itemTwoOrdered = true; } else { itemTwoOrdered = false; };
        if (howManyItemThree != 0) { itemThreeOrdered = true; } else { itemThreeOrdered = false; };

        Graphics recieptGraphics = recieptPanel.CreateGraphics();
        Font recieptRegular = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        Font recieptBold = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        SolidBrush recieptBrush = new SolidBrush(Color.Black);

        recieptGraphics.DrawString(headerName, recieptBold, recieptBrush, 16, 16);

        if (itemOneOrdered == true) { recieptGraphics.DrawString("Burger x " + howManyItemOne + "   =   " + (itemOnePrice*howManyItemOne), recieptRegular, recieptBrush, 16, 32); }
        if (itemTwoOrdered == true) { recieptGraphics.DrawString("Fries x " + howManyItemTwo + "   =   " + (itemTwoPrice * howManyItemTwo), recieptRegular, recieptBrush, 16, 48); }
        if (itemThreeOrdered == true) { recieptGraphics.DrawString("Coke x " + howManyItemThree + "   =   " + (itemThreePrice * howManyItemThree), recieptRegular, recieptBrush, 16, 64); }

        recieptGraphics.DrawString("Sub-Total = " + (subTotal.ToString(".##")), recieptRegular, recieptBrush, 16, 96);
        recieptGraphics.DrawString("Tax = " + (tax.ToString(".##")), recieptRegular, recieptBrush, 16, 112);
        recieptGraphics.DrawString("Total = " + (total.ToString(".##")), recieptRegular, recieptBrush, 16, 128);
        recieptGraphics.DrawString(footerName, recieptBold, recieptBrush, 16, 144);
        
        }
    }
}
