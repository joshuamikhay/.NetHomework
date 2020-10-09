using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week3_OrderExp
{
    class Program
    {
        static OrderService Service = new OrderService();
        static void Main(string[] args)
        {
            bool enterflag = true;
            while (enterflag)
            {
                Console.WriteLine("Welcome to order management system.\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[A] Add.     [R] Remove.     [F] Find.      [E] Export.      [I] Import.        [Q] Quit.");
                string enterSentence = Console.ReadLine();
                if (enterSentence.ToLower() == "q")
                {
                    enterflag = false;
                }

                if (enterSentence.ToLower() == "a")
                {
                    Add();
                }

                if (enterSentence.ToLower() == "r")
                {
                    Remove();
                }

                if (enterSentence.ToLower() == "f")
                {
                    Find();
                }

                if (enterSentence.ToLower() == "e")
                {
                    Export();
                }

                if (enterSentence.ToLower() == "e")
                {
                    Export();
                }
            }
        }
        static void Export()
        {
            Service.export();
        }

        static void Import()
        {
            while (true)
            {
                Console.WriteLine("Enter the data path: , [Q] to quit");
                string Path = Console.ReadLine();
                if (Path.ToLower() == "q")
                {
                    break;
                }
                if (System.IO.File.Exists(Path))
                {
                    Order newOrder = Service.import(Path);
                    Console.WriteLine("This order has been imported to the dataBase.");
                    Console.WriteLine(newOrder.ToString());
                    break;
                }
                Console.WriteLine("File doesn't exsist.");
            }

        }

        static void Find()
        {
            bool findFlag = true;
            while (findFlag)
            {
                Console.WriteLine("\nEnter \"V\" to view all orders.");
                Console.WriteLine("Or, enter the query element. Like this, \"objID objName supplier buyer num unitPrice\", they will be splited by \"Blank\"");
                Console.WriteLine("if some elements is blank, replace it with \"_\". Like this, \"objID _ supplier _ >=10 <7 _\"");
                Console.WriteLine("Enter \"Q\" to return");
                string element = Console.ReadLine();

                if (element.ToLower() == "q")
                {
                    findFlag = false;
                    return;
                }

                if (element.ToLower() == "v")
                {
                    if (Service.Count() != 0)
                    {
                        Service.displayAllDetails();
                        continue;
                    }
                    Console.WriteLine("You have no orders yet.");
                    continue;
                }

                string[] elements = element.Split(' ');

                if (elements.Length != 7)
                {
                    Console.WriteLine("\nThe elements you have entered are illegal.\n");
                    continue;
                }

                List<Order> queryResult = Service.find(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6]);

                if (queryResult != null)
                {
                    bool quitLabel = true;
                    while (quitLabel)
                    {
                        Console.WriteLine("What kind of order you want to be displayed?");
                        Console.WriteLine("[1]By objectID, [2]By objectName, [3]By supplier, [4]buyer, [5]num, [6]unit price, [7]total price, [Q]quit");
                        string orderChoice = Console.ReadLine();
                        if (orderChoice.ToLower() == "q")
                        {
                            break;
                        }
                        bool isSuccess = int.TryParse(orderChoice, out int choice);
                        if (isSuccess)
                        {
                            while (true)
                            {
                                Console.WriteLine("What kind of order you want to be displayed?");
                                Console.WriteLine("[1]Increasing, [2]Decreasing, [Q]quit");
                                string upOrDown = Console.ReadLine();
                                if (upOrDown.ToLower() == "q")
                                {
                                    quitLabel = false;
                                    break;
                                }
                                bool isSuccess2 = int.TryParse(upOrDown, out int upDown);

                                if (isSuccess2)
                                {
                                    queryResult = Service.Sort(queryResult, choice, upDown);

                                    foreach (Order order in queryResult)
                                    {
                                        List<OrderDetails> Details = order.getDetails();
                                        Console.WriteLine(order.ToString());
                                    }
                                    quitLabel = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Remove()
        {
            bool removeEnterFlag = true;
            while (removeEnterFlag)
            {
                Console.WriteLine("\nPlease enter the order ID you want to remove. Or else, press \"Enter\" to search it, enter [Q] to return last screen.");
                string firstEnter = Console.ReadLine();
                if (firstEnter.ToLower() == "q")
                {
                    return;
                }

                if (firstEnter == "")
                {
                    Console.WriteLine("\nEnter \"V\" to view all orders.");
                    Console.WriteLine("Or, enter the query element. Like this, \"objID objName supplier buyer num unitPrice\", they will be splited by \"Blank\"");
                    Console.WriteLine("if some elements is blank, replace it with \"_\". Like this, \"objID _ supplier _ >=10 <7 _\"");
                    string element = Console.ReadLine();
                    if (element.ToLower() == "v")
                    {
                        if (Service.Count() != 0)
                        {
                            Service.displayAllDetails();
                            continue;
                        }
                        Console.WriteLine("You have no orders yet.");
                        continue;
                    }
                    string[] elements = element.Split(' ');
                    if (elements.Length != 7)
                    {
                        Console.WriteLine("\nThe elements you have entered are illegal.\n");
                        continue;
                    }

                    List<Order> queryResult = Service.find(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6]);

                    if (queryResult != null)
                    {
                        foreach (Order order in queryResult)
                        {
                            Console.WriteLine(order.ToString());
                        }

                        while (true)
                        {
                            if (queryResult.Count == 0)
                            {
                                break;
                            }
                            Console.WriteLine("These orders will be deleted, is it ok for you?[y/n]");
                            string lastAnswer = Console.ReadLine();

                            if (lastAnswer.ToLower() == "y")
                            {
                                foreach (Order order in queryResult)
                                {
                                    Service.removeOrder(order.orderID.ToString());
                                    Console.WriteLine("Order removed.");
                                }
                                break;
                            }

                            else if (lastAnswer.ToLower() == "n")
                            {
                                removeEnterFlag = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Add an order
        static void Add()
        {
            bool detailEnterFlag = true;
            while (detailEnterFlag)
            {
                Console.WriteLine("\nPlease enter objectID, objectName, supplier, buyer, the number of it and the unit price. Or enter [Q] to return last screen.");
                Console.WriteLine("They will be splited by \"Blank\".");
                string Details = Console.ReadLine();
                if (Details.ToLower() == "q")
                {
                    return;
                }
                string[] details = Details.Split(' ');
                if (details.Length != 6)
                {
                    Console.WriteLine("\nThe elements you have entered are illegal.\n");
                    continue;
                }

                bool numParsed = int.TryParse(details[4], out int num);
                bool unitPriceParsed = float.TryParse(details[5], out float unitPrice);
                if (!(numParsed && unitPriceParsed))
                {
                    Console.WriteLine("The elements you have entered are illegal.\n");
                    continue;
                }
                OrderDetails newDetail = new OrderDetails(details[0], details[1], details[2], details[3], num, unitPrice);
                int sameID = Service.isSameDetailsExsist(newDetail);

                if (sameID == -1)
                {
                    Console.WriteLine("There is no similar order in data base, do you want to merge it into an order?[y/n]");
                    string answer1 = Console.ReadLine();

                    if (answer1.ToLower() == "y")
                    {
                        bool mergeFlag = true;
                        while (mergeFlag)
                        {
                            Console.WriteLine("Which order you want to merge? Please enter the orderID, if you don't know, " +
                            "look it up in [Find.], you can enter \"Q\" to quit the procedure.");
                            string answer2 = Console.ReadLine();

                            // quit add
                            if (answer2.ToLower() == "q")
                            {
                                detailEnterFlag = false;
                                break;
                            }
                            bool answer2int = int.TryParse(answer2, out int ID);
                            if (answer2int)
                            {
                                if (Service.isSameIDExsist(ID))
                                {
                                    Service.addDetails(ID, details[0], details[1], details[2], details[3], num, unitPrice);
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("OrderID doesn't exsist.");
                                }
                            }

                            else
                            {
                                Console.WriteLine("Character illegal");
                            }
                        }
                    }
                    else if (answer1.ToLower() == "n")
                    {
                        int newOrderID = Service.addOrder();
                        Service.addDetails(newOrderID, details[0], details[1], details[2], details[3], num, unitPrice);
                    }
                    else
                    {
                        continue;
                    }
                }

                else
                {
                    Service.addDetails(sameID, details[0], details[1], details[2], details[3], num, unitPrice);
                }
            }
        }
    }
}
