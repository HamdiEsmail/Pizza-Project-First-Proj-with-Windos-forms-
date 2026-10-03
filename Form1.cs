using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void GetLableSize() {
            if (rbSmall.Checked)
            {
                labSize.Text = "Small";
            }
            else if (rbMedium.Checked)
            {
                labSize.Text = "Medium";
            }
            else { 
                labSize.Text = "Large";

            }
            ;
        
        }
        float GetSizePrice() {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {

                return Convert.ToSingle(rbMedium.Tag);

            }
            else { 
                return Convert.ToSingle(rbLarge.Tag);

            }


        }

        void GetLabelCrustType() {
            if (rbThick.Checked)
            {
                labCrustType.Text = "Thick";
            }
            else { 
            
                labCrustType.Text = "Thin";

            }

        }
        float GetCrustTypePrice() {
            if (rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }
            else { 
            
                return Convert.ToSingle(rbThin.Tag);

            }

        }

        void GetWhereToEat() {
            if (rbEatIn.Checked)
            {
                LabWhereToEat.Text = "Eat In";

            }
            else { 
                LabWhereToEat.Text = "Take Out";

            }

        }

        float GetWhereToEatPrice() {
            if (rbEatIn.Checked)
            {
                return Convert.ToSingle(rbEatIn.Tag);
            }
            else { 
                return Convert.ToSingle(rbTakeOut.Tag);


            }

        }

        void GetLabelTopping() {
            string Topping="";
            if (cbExtraCheese.Checked) {
                Topping = "Extra Cheese ";
            }
            if (cbOnion.Checked) {
                Topping += ", Onion";
            }
            if (cbMashrooms.Checked) {
                Topping += ", Mashrooms";


            }
            if (cbOlives.Checked) {
            
                Topping += "\n, Olives";

            }
            if (cbTomatoes.Checked) {
                Topping += ", Tomatoes";

            }
            if (cbGreenPeppers.Checked) {
                Topping += "\n, Green Peppers";

            }
            if (Topping.StartsWith(",")) {
                Topping = Topping.Substring(1, (Topping.Length-1)).Trim();
            }
            if (Topping=="") {
            labTopping.Text = "No Topping";

            } else labTopping.Text = Topping;

        }
        float GetToppingPrice() {
            float ToppingPrice=0;
            if (cbExtraCheese.Checked) {
                ToppingPrice += Convert.ToSingle(cbExtraCheese.Tag);
            }
            if (cbOnion.Checked) {
                ToppingPrice += Convert.ToSingle(cbOnion.Tag);

            }
            if (cbMashrooms.Checked) {
                ToppingPrice += Convert.ToSingle(cbMashrooms.Tag);

            }
            if (cbOlives.Checked) {
                ToppingPrice += Convert.ToSingle(cbOlives.Tag);

            }
            if (cbTomatoes.Checked) {
                ToppingPrice += Convert.ToSingle(cbTomatoes.Tag);
            }
            if (cbGreenPeppers.Checked) {
            
                ToppingPrice += Convert.ToSingle(cbGreenPeppers.Tag);

            }
            return ToppingPrice;

        }
        float GetTotalPrice() {
            return GetToppingPrice() + GetWhereToEatPrice() + GetCrustTypePrice() + GetSizePrice();
        }
        void resetButton() {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbCrustType.Enabled = true;

            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;

            cbExtraCheese.Checked = false;
            cbMashrooms.Checked = false;
            cbOnion.Checked = false;
            cbGreenPeppers.Checked = false;
            cbTomatoes.Checked = false;
            cbOlives.Checked = false;


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();


        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void labMakeYourPizza_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSmall_CheckedChanged(object sender, EventArgs e)
        {
            GetLableSize();
            LabTotalPrice.Text ="$"+ GetTotalPrice().ToString();


        }

        private void btnMedium_CheckedChanged(object sender, EventArgs e)
        {
            GetLableSize();

            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();




        }

        private void btnLarge_CheckedChanged(object sender, EventArgs e)
        {
            GetLableSize();

            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();


        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelCrustType();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();


        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelCrustType();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();


        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();



        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            GetWhereToEat();
            LabTotalPrice.Text ="$"+ GetTotalPrice().ToString();


        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            GetWhereToEat();
            LabTotalPrice.Text ="$"+ GetTotalPrice().ToString();


        }

        private void cbMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();

        }

        private void TotalPrice_Click(object sender, EventArgs e)
        {


        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();

        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelTopping();
            LabTotalPrice.Text = "$" + GetTotalPrice().ToString();

        }

        private void none_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to confirm ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                MessageBox.Show("Order Placed Successfuly ");
            
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
            gbCrustType.Enabled = false;
           
            
            } ;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure To Reset Order ?", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { 
            
            resetButton();
               
            }


        }

        private void labSize_Click(object sender, EventArgs e)
        {

        }
    }
}
