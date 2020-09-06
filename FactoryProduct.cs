using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingPromotionNew
{
   public   class FactoryProduct
    {

       public IProductType GetProduct(string key)
       {
           switch(key)
           {
               case "A":
                   {
                       return new A();
                      
                   }
               case "B":
                   {
                       return new B();
                       
                   }
               case "C":
                   {
                       return new C();
                       
                   }
               case "D":
                   {
                       return new D();
                       
                   }
              default:
                   {
                       return null;
                   }
                  

           }

       }



    }
}
