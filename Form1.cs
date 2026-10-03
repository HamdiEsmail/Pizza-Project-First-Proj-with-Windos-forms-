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
           


        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
          



        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
           
           
            
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
          

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
