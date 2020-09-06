using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ShippingPromotionNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterChoice = 1;
            string  productType= string.Empty;

            int productQuantity;
            Cart cart = new Cart();

           
            //while (enterChoice == 1)
            //{
            //    //productType.Clear();
            //    Console.WriteLine("Enter ProductType (A,B,C,D)");
            //     productType =  Console.ReadLine();
                 
            //     Console.WriteLine("Enter Quantity");
            //     productQuantity = Convert.ToInt32(Console.ReadLine());


            //     cart.ProductTypeWithQuantity.Add(productType, productQuantity);

            //     Console.WriteLine("Do You want to exit press Y");
            //     if (Console.ReadLine() == "Y")
            //         enterChoice = 0;
                 

            //}



            cart.ProductTypeWithQuantity.Add("A", 3);

            cart.ProductTypeWithQuantity.Add("B", 5);
            cart.ProductTypeWithQuantity.Add("C", 1);
            cart.ProductTypeWithQuantity.Add("D", 1);

            cart.CalcualteTotal();

            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
               .Where(mytype => mytype .GetInterfaces().Contains(typeof(IPromotion))))
            {

                   var instance = (IPromotion)Activator.CreateInstance(mytype);

                
                   cart.ApplyDiscount(instance);
                    
           }


            int OrderTotal = cart.ReturnOrderTotal();

            Console.WriteLine("Total Order Value is " + OrderTotal);


            Console.ReadLine();


        }

    }
}
