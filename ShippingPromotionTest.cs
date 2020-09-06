using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace ShippingPromotionNew
{
   [TestFixture]
   public  class ShippingPromotionTest
    {


        [TestCase]

        public void FirstTest()
        {
            Cart cart = new Cart();


            cart.ProductTypeWithQuantity.Add("A", 1);

            cart.ProductTypeWithQuantity.Add("B", 1);
            cart.ProductTypeWithQuantity.Add("C", 1);
            

            cart.CalcualteTotal();

            cart.ApplyDiscount(new APromotion());

            cart.ApplyDiscount(new BPromotion());

            cart.ApplyDiscount(new CDPromotion());

            int OrderTotal = cart.ReturnOrderTotal();

            Assert.AreEqual(OrderTotal, 100);


        }



        [TestCase]

        public void SecondTest()
        {
            Cart cart = new Cart();


            cart.ProductTypeWithQuantity.Add("A", 5);

            cart.ProductTypeWithQuantity.Add("B", 5);
            cart.ProductTypeWithQuantity.Add("C", 1);


            cart.CalcualteTotal();

            cart.ApplyDiscount(new APromotion());

            cart.ApplyDiscount(new BPromotion());

            cart.ApplyDiscount(new CDPromotion());

            int OrderTotal = cart.ReturnOrderTotal();

            Assert.AreEqual(OrderTotal, 370);


        }


        [TestCase]

        public void ThirdTest()
        {
            Cart cart = new Cart();


            cart.ProductTypeWithQuantity.Add("A", 3);

            cart.ProductTypeWithQuantity.Add("B", 5);
            cart.ProductTypeWithQuantity.Add("C", 1);
            cart.ProductTypeWithQuantity.Add("C", 1);

            cart.CalcualteTotal();

            cart.ApplyDiscount(new APromotion());

            cart.ApplyDiscount(new BPromotion());

            cart.ApplyDiscount(new CDPromotion());

            int OrderTotal = cart.ReturnOrderTotal();

            Assert.AreEqual(OrderTotal, 280);


        }


    }
}
