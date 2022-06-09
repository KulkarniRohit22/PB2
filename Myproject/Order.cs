using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject
{
    class Order
    {
        int orderid;
        string custname;
        string city;
        ArrayList items;


        public Order(int orderid, string custname, string city, ArrayList items )
        {
            this.orderid = orderid;
            this.custname = custname;
            this.city = city;
            this.items = items;
        }
    }

    class TestOrder
    {
        static void Main(string[] args)
        {
            ArrayList itemList = new ArrayList();
            itemList.Add("Laptop");
            itemList.Add("Headset");
            itemList.Add("Charger");

            Order o = new Order(101,"Aadarsh","pune",itemList);

            ArrayList itemList2 = new ArrayList();
            itemList2.Add("laptop");
            itemList2.Add("mobile");
            itemList2.Add("washing machine");

            Order o2 = new Order(102, "Jayraj", "mumbai", itemList2);


            //create arraylist of 5 order objects in which  data will be accepted dynamically.
            ArrayList orderList = new ArrayList();

            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("enter orderid,custname, city");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string cname = Console.ReadLine();
                Console.WriteLine("Enter how many items u want to order");
                int c = int.Parse(Console.ReadLine());

                ArrayList itemlist = new ArrayList();
                for(int j=1; j<=c; j++)
                {
                    Console.WriteLine($"Add {j} item in ur order");
                    string item = Console.ReadLine();
                    itemlist.Add(item);
                }
                orderList.Add(new Order(id, name, cname, itemlist));
            }
        }
    }
}
