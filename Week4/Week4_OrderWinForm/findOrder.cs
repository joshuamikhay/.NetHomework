using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_OrderWinForm
{
    public partial class Find : Form
    {
        private OrderService service;
        public findOrder(OrderService service)
        {
            InitializeComponent();
            this.service = service;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string objID = objID_text.Text;
            string objName = objName_text.Text;
            string supplier = supllier_text.Text;
            string buyer = buyer_text.Text;
            bool numConvert = int.TryParse(num_text.Text, out int num);
            bool unitPriceConvert = float.TryParse(unitPrice_text.Text, out float unitPrice);
            bool totalPriceConvert = float.TryParse(totalPrice_text.Text, out float totalPrice);
            string numStr = "";
            string unitPriceStr = "";
            string totalStr = "";

            if (!(numConvert && unitPriceConvert && totalPriceConvert) && (num_text.Text != "" && unitPrice_text.Text != "" && totalPrice_text.Text != ""))
            {
                warning warningWindow = new warning();
                warningWindow.setText("Warning!", "Character illegal.");
                warningWindow.Show();
                return;
            }

            if (numConvert)
            {
                numStr = num_sign.SelectedItem.ToString() + num.ToString();
            }

            if (unitPriceConvert)
            {
                unitPriceStr = unitPrice_sign.SelectedItem.ToString() + unitPrice.ToString();
            }

            if (totalPriceConvert)
            {
                totalStr = totalPrice_sign.SelectedItem.ToString() + totalPrice.ToString();
            }

            List<Order> results = service.find(objID, objName, supplier, buyer, numStr, unitPriceStr, totalStr);

            displayWindow displayWindow = (displayWindow)this.Owner;
            displayWindow.refresh(results);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalPrice_sign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void num_sign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unitPrice_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyer_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void objID_label_Click(object sender, EventArgs e)
        {

        }

        private void num_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void objName_label_Click(object sender, EventArgs e)
        {

        }

        private void supplier_label_Click(object sender, EventArgs e)
        {

        }

        private void objName_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void objID_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyer_label_Click(object sender, EventArgs e)
        {

        }

        private void supllier_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitPrice_label_Click(object sender, EventArgs e)
        {

        }

        private void num_label_Click(object sender, EventArgs e)
        {

        }

        private void totalPrce_label_Click(object sender, EventArgs e)
        {

        }

        private void totalPrice_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitPrice_sign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_text_Click(object sender, EventArgs e)
        {

        }
    }
}
