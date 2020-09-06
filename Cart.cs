using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingPromotionNew
{
    public class Cart
    {
        public Dictionary<string, int> ProductTypeWithQuantity { get; set; }

        public int ProductTotalWithOutDiscount { get; set; }

        public int TotalDiscount { get; set; }

        public Cart()
        {
            ProductTypeWithQuantity = new Dictionary<string, int>();

        }

        public  int  CalcualteTotal()
        {
            //     var type = typeof(IProductType);
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //.SelectMany(s => s.GetTypes());
            int productPrice = 0;

            FactoryProduct factoryProduct = new FactoryProduct();

            foreach (var key in ProductTypeWithQuantity.Keys)
            {
                IProductType product = factoryProduct.GetProduct(key);

                productPrice =   ProductTypeWithQuantity[key] *  product.productPrice;

                ProductTotalWithOutDiscount = ProductTotalWithOutDiscount + productPrice;

            }


            return ProductTotalWithOutDiscount;


       


        }


        public  void  ApplyDiscount(IPromotion promotion)
        {
           TotalDiscount = TotalDiscount +  promotion.ApplyDiscount(this);

        }

        public int ReturnOrderTotal()
        {

            return ProductTotalWithOutDiscount - TotalDiscount;

        }

     

    }
}

