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
        float GetLabelSizePrice() {
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
         

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



        }

        private void btnMedium_CheckedChanged(object sender, EventArgs e)
        {
            GetLableSize();





        }

        private void btnLarge_CheckedChanged(object sender, EventArgs e)
        {
            GetLableSize();



        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelCrustType();


        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            GetLabelCrustType();


        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
          



        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            GetWhereToEat();
           
            
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            GetWhereToEat();
          

            }

        private void cbMashrooms_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void TotalPrice_Click(object sender, EventArgs e)
        {


        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void none_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
          
           
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
           

        }

        private void labSize_Click(object sender, EventArgs e)
        {

        }
    }
}
