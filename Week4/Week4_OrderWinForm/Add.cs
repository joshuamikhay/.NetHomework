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
    public partial class Add : Form
    {
        private OrderService service;
        public Add(OrderService service)
        {
            InitializeComponent();
            this.service = service;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }
        public void renewService(OrderService service)
        {
            this.service = service;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string objID = objID_text.Text;
            string objName = objName_text.Text;
            string supplier = supllier_text.Text;
            string buyer = buyer_text.Text;
            bool numConvert = int.TryParse(num_text.Text, out int num);
            bool unitPriceConvert = float.TryParse(unitPrice_text.Text, out float unitPrice);
            if (numConvert && unitPriceConvert)
            {
                OrderDetails newDetails = new OrderDetails(objID, objName, supplier, buyer, num, unitPrice);
                int sameID = service.isSameDetailsExsist(newDetails);
                if (sameID == -1)
                {
                    int newID = service.addOrder();
                    service.addDetails(newID, objID, objName, supplier, buyer, num, unitPrice);
                    warning warningWindow = new warning();
                    warningWindow.setText("Succeeded", "Data has been entered");
                    warningWindow.Show();
                    order_management_system system = (order_management_system)this.Owner;
                    system.renewService(service);
                    this.Close();
                }

                else
                {
                    ChooseOrder chooseWindow = new ChooseOrder(service, newDetails);
                    order_management_system system = (order_management_system)this.Owner;
                    chooseWindow.Show(system);
                    this.Close();
                }
            }

            else
            {
                warning warningWindow = new warning();
                warningWindow.setText("Warning!", "Character illegal.");
                warningWindow.Show();
            }
        }

        public OrderService GetService()
        {
            return this.service;
        }

        private void objName_label_Click(object sender, EventArgs e)
        {

        }

        private void objID_label_Click(object sender, EventArgs e)
        {

        }

        private void supplier_label_Click(object sender, EventArgs e)
        {

        }

        private void buyer_label_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void unitPrice_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyer_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void supllier_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void objName_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitPrice_label_Click(object sender, EventArgs e)
        {

        }

        private void num_label_Click(object sender, EventArgs e)
        {

        }

        private void objID_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_text_Click(object sender, EventArgs e)
        {

        }
    }
}
