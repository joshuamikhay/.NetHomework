using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Week3_OrderExp
{
    public class Order
    {
        public int orderID { get; set; }
        private float totalPrice;
        private List<OrderDetails> orderDetails;

        public Order()
        {

        }

        public List<OrderDetails> getDetails()
        {
            return orderDetails;
        }

        public void gainDetails(List<OrderDetails> orderDetails)
        {
            this.orderDetails = orderDetails;
        }

        public float showPrice()
        {
            return totalPrice;
        }

        public Order(int orderId)
        {
            this.orderID = orderID;
            orderDetails = new List<OrderDetails>();
            this.totalPrice = 0;
        }

        public override string ToString()
        {
            string result = "";
            foreach (OrderDetails orderDetail in orderDetails)
            {
                result = "order ID : " + orderID + ", objectID : " + orderDetail.objectID + ", objectName : " + orderDetail.objectName + ", supplier : " + orderDetail.supplier
                           + ", buyer : " + orderDetail.buyer + ", number : " + orderDetail.number + ", unit price: " + orderDetail.unitPrice + ", total price: " + orderDetail.totalPrice + "\n";
            }
            result = result + "order ID: " + orderID + ", total price: " + showPrice() + "\n";
            return result;
        }

        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Order));

            var path = "./SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }

        

        //Adding Order
        public void addDetails(string objectID, string objectName, string supplier, string buyer, int number, float unitPrice)
        {
            OrderDetails newDetail = new OrderDetails(objectID, objectName, supplier, buyer, number, unitPrice);
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Equals(newDetail))
                {
                    orderDetails[i].number += newDetail.number;
                    SumUp();
                    Console.WriteLine("\nSimilar Order is already on the Database");
                    Console.WriteLine($"You currently have {orderDetails.Count} order(s).");
                    return;
                }
            }
            Console.WriteLine("\nprocessing");
            orderDetails.Add(newDetail);
            Console.WriteLine($"You currently have {orderDetails.Count} order(s).");
            SumUp();
            return;
        }

        // calculating total Price
        public void SumUp()
        {
            totalPrice = 0;
            foreach (OrderDetails detail in orderDetails)
            {
                totalPrice += detail.unitPrice * detail.number;
                detail.totalPrice = detail.number * detail.unitPrice;
            }
        }
    }
}
