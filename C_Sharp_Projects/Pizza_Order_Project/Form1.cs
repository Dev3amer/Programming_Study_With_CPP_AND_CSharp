using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Project
{
    public partial class frm_MakePizza : Form
    {
        public frm_MakePizza()
        {
            InitializeComponent();
        }

        // funcations for order/reset buttons
        private void DisableControls()
        {
            gb_Crust.Enabled = false;
            gb_Size.Enabled = false;
            gb_Toppings.Enabled = false;
            gb_WhereToEat.Enabled = false;
            btn_Order.Enabled = false;
        }
        private void EnableControls()
        {
            gb_Crust.Enabled = true;
            gb_Size.Enabled = true;
            gb_Toppings.Enabled = true;
            gb_WhereToEat.Enabled = true;
            btn_Order.Enabled = true;
        }
        private void setDefaultValues()
        {
            rb_Small.Checked = true;
            rb_EatIn.Checked = true;
            rb_Thin.Checked = true;

            chk_ExtraChees.Checked = false;
            chk_GreenPeppers.Checked = false;
            chk_Mushrooms.Checked = false;
            chk_Oilves.Checked = false;
            chk_Onion.Checked = false;
            chk_Tomatoes.Checked = false;
            lbl_OrderS_Toppings.Text = "No Toopings";
        }

        // funcation for update order summary with click on controls
        private void updateSize()
        {
            getTotalPrice();
            if (rb_Small.Checked)
            {
                lbl_OrderS_Size.Text = "Small";
                return;
            }
            if (rb_Meduim.Checked)
            {
                lbl_OrderS_Size.Text = "Meduim";
                return;
            }
            if (rb_Larg.Checked)
            {
                lbl_OrderS_Size.Text = "Larg";
                return;
            }
        }
        private void updateCrust()
        {
            getTotalPrice();
            if (rb_Thin.Checked)
            {
                lbl_OrderS_CrustType.Text = "Think Crust";
                return;
            }
            else
            {
                lbl_OrderS_CrustType.Text = "Think Crust";
                return;
            }
        }
        private void updateToppings()
        {
            getTotalPrice();
            string Toppings = "";
            if (chk_ExtraChees.Checked)
                Toppings += "Extra Chees, ";
            if (chk_GreenPeppers.Checked)
                Toppings += "GreenPeppers, ";
            if (chk_Mushrooms.Checked)
                Toppings += "Mushrooms, ";
            if (chk_Oilves.Checked)
                Toppings += "Oilves, ";
            if (chk_Onion.Checked)
                Toppings += "Onion, ";
            if (chk_Tomatoes.Checked)
                Toppings += "Tomatoes, ";
            var index = Toppings.LastIndexOf(',');
            if (!(Toppings == ""))
                lbl_OrderS_Toppings.Text = Toppings.Remove(index, 1); 
        }
        private float getSizePrice()
        {
            if (rb_Small.Checked)
                return Convert.ToSingle(rb_Small.Tag);
            else if (rb_Meduim.Checked)
                return Convert.ToSingle(rb_Meduim.Tag);
            else
                return Convert.ToSingle(rb_Larg.Tag);

        }
        private float getCrustPrice()
        {
            if (rb_Thin.Checked)
                return Convert.ToSingle(rb_Thin.Tag);
            else
                return Convert.ToSingle(rb_Think.Tag);
        }
        private float getToppingsPrice()
        {
            float TotalToppingsPrice = 0f;
            if (chk_ExtraChees.Checked)
                TotalToppingsPrice += Convert.ToSingle(chk_ExtraChees.Tag);
            if (chk_GreenPeppers.Checked)
                TotalToppingsPrice += Convert.ToSingle(chk_GreenPeppers.Tag);
            if (chk_Mushrooms.Checked)
                TotalToppingsPrice +=  Convert.ToSingle(chk_Mushrooms.Tag);
            if (chk_Oilves.Checked)
                TotalToppingsPrice += Convert.ToSingle(chk_Oilves.Tag);
            if (chk_Onion.Checked)
                TotalToppingsPrice += Convert.ToSingle(chk_Onion.Tag);
            if (chk_Tomatoes.Checked)
                TotalToppingsPrice += Convert.ToSingle(chk_Tomatoes.Tag);

            return TotalToppingsPrice;
        }
        private void getTotalPrice()
        {
            float totalPrice = getSizePrice() 
                + getCrustPrice() 
                + getToppingsPrice();

            lbl_OrderS_Price.Text ="$" + totalPrice.ToString();
        }

        //btn_Order Event Funcation
        private void MakeOrder(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you Want Take This Order?", "Confirm!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                DisableControls();
                btn_Reset.Enabled = true;
            }
            

        }

        //btn_Reset Event Funcation
        private void ResetOrder(object sender, EventArgs e)
        {
            EnableControls();
            setDefaultValues();
            btn_Reset.Enabled = false;
        }



        //funcation for changes on radio&check boxs
        private void rb_Small_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rb_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rb_Larg_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rb_Thin_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rb_Think_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rb_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbl_OrderS_WhereToEat.Text = "Eat in";
        }

        private void rb_TakeAway_CheckedChanged(object sender, EventArgs e)
        {
            lbl_OrderS_WhereToEat.Text = "Take Away";
        }

        private void chk_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chk_Onion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chk_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chk_Oilves_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chk_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chk_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
    }
}
