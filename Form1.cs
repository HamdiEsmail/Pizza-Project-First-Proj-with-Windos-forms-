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
      
        private int _TotalPrice;
        private List <string> _AllTopping=new List<string>();
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTomatoes.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbTomatoes.Tag);

                _AllTopping.Add("Tomatoes");


            }
            else
            {
                _TotalPrice -= Convert.ToInt32(cbTomatoes.Tag);
                _AllTopping.Remove("Tomatoes");


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();
            labTopping1.Text = String.Join(",", _AllTopping);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnion.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbOnion.Tag);

                _AllTopping.Add("Onion");


            }
            else { 
                _TotalPrice -= Convert.ToInt32(cbOnion.Tag);
                _AllTopping.Remove("Onion");


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();
            labTopping1.Text = String.Join(",",_AllTopping);

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
            if (rbSmall.Checked)
            {
                labSize1.Visible = true;
                labSize1.Text = "Small";
                _TotalPrice += Convert.ToInt32(rbSmall.Tag);

            }
            else _TotalPrice -= Convert.ToInt32(rbSmall.Tag);
            LabTotalPrice1.Text = "$" + _TotalPrice;




        }

        private void btnMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                labSize1.Visible = true;
                labSize1.Text = "Medium";

                _TotalPrice += Convert.ToInt32(rbMedium.Tag);


            }
            else
            {
                _TotalPrice -= Convert.ToInt32(rbMedium.Tag);

            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();





        }

        private void btnLarge_CheckedChanged(object sender, EventArgs e)
        {

            if (rbLarge.Checked)
            {
                labSize1.Visible = true;
                labSize1.Text = "Large";

                _TotalPrice += Convert.ToInt32(rbLarge.Tag);
            }
            else
            {
                _TotalPrice -= Convert.ToInt32(rbLarge.Tag);

            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();


        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                labCrustType1.Text = "Thin";
                _TotalPrice += Convert.ToInt32(rbThin.Tag);
            }
            else
            {
                _TotalPrice -= Convert.ToInt32(rbThin.Tag);


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();


        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                labCrustType1.Text = "Thick";
                _TotalPrice += Convert.ToInt32(rbThick.Tag);

            }
            else { 
                _TotalPrice -= Convert.ToInt32(rbThick.Tag);


            }
            LabTotalPrice1.Text = "$" + _TotalPrice;

        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExtraCheese.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbExtraCheese.Tag);
                if (!_AllTopping.Contains("Extra Cheese")) {
                    _AllTopping.Add("Extra Cheese");
                }

            }
            else { 
                _TotalPrice -= Convert.ToInt32(cbExtraCheese.Tag);
                _AllTopping.Remove("Extra Cheese");



            }
            LabTotalPrice1.Text = "$"+_TotalPrice.ToString();
            labTopping1.Text = String.Join(",",_AllTopping);



        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                LabWhereToEat1.Text = "Eat In";


            }
           
            
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                LabWhereToEat1.Text = "Take Out";

            }

            }

        private void cbMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMashrooms.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbMashrooms.Tag);

                _AllTopping.Add("Mashrooms");


            }
            else
            {
                _TotalPrice -= Convert.ToInt32(cbMashrooms.Tag);
                _AllTopping.Remove("Mashrooms");


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();
            labTopping1.Text = String.Join(",", _AllTopping);
            foreach (string topp in _AllTopping) {
            
            
            }
        }

        private void TotalPrice_Click(object sender, EventArgs e)
        {


        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOlives.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbOlives.Tag);

                _AllTopping.Add("Olives");


            }
            else
            {
                _TotalPrice -= Convert.ToInt32(cbOlives.Tag);
                _AllTopping.Remove("Olives");


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();
            labTopping1.Text = String.Join(",", _AllTopping);
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreenPeppers.Checked)
            {
                _TotalPrice += Convert.ToInt32(cbGreenPeppers.Tag);

                _AllTopping.Add("Green Peppers");


            }
            else
            {
                _TotalPrice -= Convert.ToInt32(cbGreenPeppers.Tag);
                _AllTopping.Remove("Green Peppers");


            }
            LabTotalPrice1.Text = "$" + _TotalPrice.ToString();
            labTopping1.Text = String.Join(",", _AllTopping);
        }

        private void none_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Ordere", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                gbParent.Enabled = false;
            
            }
            ;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbParent.Enabled = true;

        }
    }
}
