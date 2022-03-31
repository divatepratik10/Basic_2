using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_2
{
    class Discount
    {
        static int price;
        public static int PROD_DISCOUNT()
        {
            Console.WriteLine("Enter Total Bill Amount : ");
            int total = Convert.ToInt32(Console.ReadLine());
            //int price;
            int discount;
            if (total < 1000)
                price = total;
            else if (total >= 1000 && total <=2499)
            {
                discount = (total * 5) / 100;
                price = total - discount;
            }
            else if (total >= 2500 && total <=3999)
            {
                discount = (total * 10) / 100;
                price = total - discount;
            }
            else if (total >= 4000)
            {
                discount = (total * 18) / 100;
                price = total - discount;
            }

            Console.WriteLine("Discounted price is Rs. {0}\nTHANK YOU. VISIT AGAIN... :)",price );
            Console.ReadLine();
            return price;

        }
    }
}
